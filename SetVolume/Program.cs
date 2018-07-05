using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetVolume
{
	class Program
	{
		static void Main(string[] args)
		{
			CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;

			double volume = defaultPlaybackDevice.Volume;
			if (double.TryParse(args[0], out volume))
			{
				defaultPlaybackDevice.Volume = volume;
			}
			else
			{
				Console.WriteLine("Invalid value");
			}


		}
	}
}
