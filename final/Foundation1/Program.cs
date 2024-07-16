using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> playList = new List<Video>();

        Video v1 = new Video("How to beat Super Mario 1-2", "Gamerdude231", 3, 50);
        v1.AddComment(new Comment("heelaspiring", "Where is luigi?"));
        v1.AddComment(new Comment("remaincyan", "I actually beat this level faster than you"));
        v1.AddComment(new Comment("directoreel", "Why do the graphics look so bad"));
        playList.Add(v1);

        Video v2 = new Video("Why I'm Quitting Youtube", "Youtube4Lyfe", 10, 24);
        v2.AddComment(new Comment("reporterkings", "We wish you the best and hope things work out!"));
        v2.AddComment(new Comment("programmerlumber", "It's such a shame that all the good youtubers end up quitting"));
        v2.AddComment(new Comment("cameramandelta", "Where is luigi?"));
        playList.Add(v2);

        Video v3 = new Video("What is bone made out of?", "bonedoctor", 3, 50);
        v3.AddComment(new Comment("engineerjohn", "This is fake, I've broken bones before and I know what's really inside"));
        v3.AddComment(new Comment("doctorsulfur", "We need more educators like you online in this day and age"));
        v3.AddComment(new Comment("agentneon", "I failed biology in high school, but this makes me wish I paid more attention"));
        playList.Add(v3);


        foreach(Video v in playList)
        {
            v.DisplayMetaData();
            Console.WriteLine();
            v.DisplayComments();
            Console.WriteLine();
        }
    }
}