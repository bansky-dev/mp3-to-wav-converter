using NAudio; 

namespace mp3_to_wav_converter;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Please specify the input mp3 audio (full path): ");
            string inputMp3File = Console.ReadLine();

            Console.Write("Please speciy the output wav audio (full path): ");
            string outputWavFile = Console.ReadLine();
        }
        catch(Exception ex)
        {
            System.Console.WriteLine($"ERROR CAUGHT: {ex}");
        }
        



    }
}
