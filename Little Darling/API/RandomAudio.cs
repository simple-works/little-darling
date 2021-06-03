using System;
using System.IO;
using CSCore.CoreAudioAPI;

namespace LittleDarling
{
    public static class RandomAudio
    {
        private static MMDevice GetDefaultMMDevice()
        {
            return new MMDeviceEnumerator().GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
        }

        private static MemoryStream GetRandomSoundStream()
        {
            Byte[][] buffers = new Byte[3][];
            buffers[0] = Properties.Resources.Baby_Whine;
            buffers[1] = Properties.Resources.Babies_Cry;
            buffers[2] = Properties.Resources.Baby_Cry_Long;
            int index = new Random().Next(0, 2);
            return new MemoryStream(buffers[index]);
        }

        public static void Play(AudioPlayer audioPlayer)
        {
            audioPlayer.OpenMp3(GetRandomSoundStream(), GetDefaultMMDevice());
            audioPlayer.Play();
        }
    }
}
