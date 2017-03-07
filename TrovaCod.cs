using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Ude;

namespace TrovaCodifica
{
	public class TrovaCod
	{
		private FileStream fs = null;
		private byte[] byteInIngresso = null;
		private byte[] byteConvertiti = null;
		private CharsetDetector cdet = new CharsetDetector();
		private string piattoPronto = "";
		private string encodingTrovato = "";
		

		public string inputEncodingOutputString(byte[] patataBollente, FileStream hotLink)
		{
			try
			{
				setBytesInIngresso(patataBollente);
				setFileStream(hotLink);
				trovaEncoding(fs);
				encode(encodingTrovato);

				return piattoPronto;
			}
			catch (Exception e)
			{
				Console.WriteLine("Something went wrong: \n{0}", e);
				return "inputEncodingOutputString ha fallito l'esecuzione";
			}
		}

		private void setBytesInIngresso(byte[] bytesInIngresso)
		{
			byteInIngresso = bytesInIngresso;
		}
		
		private void setFileStream(FileStream hotLink)
		{
			fs = hotLink;
		}

		private void trovaEncoding(FileStream fileStream)
		{
			cdet.Feed(fileStream);
			cdet.DataEnd();
			encodingTrovato = cdet.Charset;
		}

		private void encode(string encoding)
		{
			switch(encoding){
				case "windows-1252":
					{
						byteConvertiti = Encoding.Convert(Encoding.GetEncoding(1252), Encoding.GetEncoding(1252), byteInIngresso);
						piattoPronto = Encoding.GetEncoding(1252).GetString(byteConvertiti);
					}
					break;
				case "UTF-8":
					{
						byteConvertiti = Encoding.Convert(Encoding.GetEncoding(65001), Encoding.GetEncoding(1252), byteInIngresso);
						piattoPronto = Encoding.GetEncoding(65001).GetString(byteConvertiti);
					}
					break;
				case "ASCII":
					{
						byteConvertiti = Encoding.Convert(Encoding.GetEncoding(20127), Encoding.GetEncoding(1252), byteInIngresso);
						piattoPronto = Encoding.GetEncoding(20127).GetString(byteConvertiti);
					}
					break;
				default:
					Console.WriteLine("\nERRORE: ENCODING TROVATO DIFFERENTE.\n");
					break;
			}
		}

	}
}
