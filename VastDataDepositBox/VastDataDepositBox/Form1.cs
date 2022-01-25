using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VastDataDepositBox
{
	public partial class Form1 : Form
	{
		Random r = new Random();
		int matrixLength = 512;

		public Form1()
		{
			InitializeComponent();
		}

		private void btnGenMatrix_Click(object sender, EventArgs e)
		{
			//matrix
			string matrix = "";
			for(int i = 0; i < matrixLength; i++)
			{
				matrix += Math.Round(r.NextDouble());
			}

			// writing   
			FileStream fs = new FileStream("matrix.vdd", FileMode.OpenOrCreate, FileAccess.Write);
			byte[] bytes = Encoding.UTF8.GetBytes(matrix);
			fs.Write(bytes, 0, bytes.Length);
			fs.Flush();
			fs.Close();
			fs.Dispose();
		}

		private void btnEncrypt_Click(object sender, EventArgs e)
		{
			string plain = txtPlainText.Text;

			//generate key
			int rem = r.Next((matrixLength/4), 3*(matrixLength/4));
			int mul = r.Next(5, 30) * matrixLength;
			int byteLength = Encoding.UTF8.GetBytes(plain).Length;
			int byteLD = byteLength.ToString().Length; //number of digits in the byte array's length
			int key = int.Parse(byteLD.ToString() + byteLength.ToString() + (mul + rem).ToString());
			lblKeyOut.Text = key.ToString();

			//get parity sequence
			int last = 0;
			int[] pS = new int[key.ToString().Length];
			int[] kS = key.ToString().Select(c => int.Parse(c.ToString())).ToArray();
			for(int i = 0; i < key.ToString().Length; i++)
			{
				pS[i] = (kS[i]+last) % 2;
				last = pS[i];
			}

			//apply parity
			string hiddenS = "";
			int[] plainS = plain.Select(c => int.Parse(c.ToString())).ToArray();
			int ki = 0;
			for(int i = 0; i < plainS.Length; i++)
			{
				hiddenS += (plainS[i] + kS[ki]) % 2;
				ki++;
				if(ki >= kS.Length) { ki = 0; }
			}
			

			//alter matrix
			FileStream fs = new FileStream("matrix.vdd", FileMode.Open, FileAccess.Write);
			fs.Seek(rem, SeekOrigin.Begin);
			byte[] bytes = Encoding.UTF8.GetBytes(hiddenS);
			fs.Write(bytes, 0, bytes.Length);
			fs.Flush();
			fs.Close();
			fs.Dispose();
		}

		private void btnDecrypt_Click(object sender, EventArgs e)
		{
			//read key
			string key = txtKey.Text;
			char[] keyCh = key.ToCharArray();

			string lenSt = "";
			for(int i = 1; i < int.Parse(keyCh[0].ToString())+1; i ++)
			{
				lenSt += keyCh[i].ToString();
			}
			int len = int.Parse(lenSt);

			string offsetSt = "";
			for(int i = int.Parse(keyCh[0].ToString())+1; i < key.Length; i++)
			{
				offsetSt += keyCh[i];
			}
			int offset = int.Parse(offsetSt) % matrixLength;

			//read in matrix part
			FileStream fs = new FileStream("matrix.vdd", FileMode.Open, FileAccess.Read);
			fs.Seek(offset, SeekOrigin.Begin);
			byte[] encodedBytes = new byte[len];
			fs.Read(encodedBytes, 0, len);
			string encodedText = Encoding.UTF8.GetString(encodedBytes);
			fs.Flush();
			fs.Close();
			fs.Dispose();

			//decode encoded text
			//get parity sequence
			int last = 0;
			int[] pS = new int[key.ToString().Length];
			int[] kS = key.ToString().Select(c => int.Parse(c.ToString())).ToArray();
			for(int i = 0; i < key.ToString().Length; i++)
			{
				pS[i] = (kS[i] + last) % 2;
				last = pS[i];
			}

			//apply parity
			string decodedText = "";
			int[] encodedS = encodedText.Select(c => int.Parse(c.ToString())).ToArray();
			int ki = 0;
			for(int i = 0; i < encodedS.Length; i++)
			{
				decodedText += (encodedS[i] + kS[ki]) % 2;
				ki++;
				if(ki >= kS.Length) { ki = 0; }
			}

			lblPlainText.Text = decodedText;
		}
	}
}
