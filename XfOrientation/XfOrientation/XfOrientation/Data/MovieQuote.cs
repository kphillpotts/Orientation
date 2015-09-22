using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace XfOrientation
{
  public class MovieQuote
  {
    public string Quote { get; set; }
    public string Character { get; set; }
    public string Movie { get; set; }
    public string ReleaseYear { get; set; }
    public string ImdbRating { get; set; }
    public string Actor { get; set; }
    public string Genre { get; set; }
    public string Poster { get; set; }
    public string Synopsis { get; set; }
    public string DisplayTitle
    {
      get { return Movie + " (" + ReleaseYear + ")"; }
    }

    public string RatingDisplay
    { 
      get { return "Rating: " + ImdbRating + "/10"; }
    }


  }

  public static class MovieQuoteGenerater
  {
    public static List<MovieQuote>  MovieQuotes { get; set; }



    static MovieQuoteGenerater()
    {
      MovieQuotes = new List<MovieQuote>();
      
      MovieQuotes.Add(new MovieQuote()
      {
        Quote = @"""That rug really tied the room together.""",
        Character = "The Dude",
        Movie = "The Big Lebowski",
        ReleaseYear="1998",
        Genre = "Comedy, Crime",
        ImdbRating = "8.2",
        Synopsis = "'The Dude' Lebowski, mistaken for a millionaire Lebowski, seeks restitution for his ruined rug and enlists his bowling buddies to help get it.",
        Poster= "BigLebowski_poster.jpg",
        Actor = "Jeff Bridges"
      });

      MovieQuotes.Add(new MovieQuote()
      {
        Quote = @"""Gentlemen, you can't fight in here! This is the War Room.""",
        Character = "President Merkin Muffley",
        Movie = "Dr. Strangelove",
        ReleaseYear = "1964",
        Genre = "Comedy, War",
        ImdbRating = "8.5",
        Synopsis = "An insane general triggers a path to nuclear holocaust that a war room full of politicians and generals frantically try to stop.",
        Poster= "DrStrangelove_poster.jpg",
        Actor = ""
      });


      MovieQuotes.Add(new MovieQuote()
      {
        Quote = "It's like, how much more black could this be? and the answer is none. None more black.",
        Character = "Nigel Tufnel",
        Movie = "This Is Spinal Tap",
        ReleaseYear = "1984",
        Genre = "Comedy",
        ImdbRating = "8.0",
        Synopsis = "Spinal Tap, one of England's loudest bands, is chronicled by film director Marty DeBergi on what proves to be a fateful tour.",
        Poster = "SpinalTap_poster.jpg",
        Actor = ""
      });

      MovieQuotes.Add(new MovieQuote()
      {
        Quote = "I'm a mog - half man, half dog. I'm my own best friend.",
        Character = "Barf",
        Movie = "Spaceballs",
        ReleaseYear = "1987",
        Genre = "Comedy, SciFi",
        ImdbRating = "7.1",
        Synopsis = "Planet Spaceball's President Skroob sends Lord Dark Helmet to steal Planet Druidia's abundant supply of air to replenish their own, and only Lone Starr can stop them.",
        Poster= "Spaceballs_poster.jpg",
        Actor = "John Candy"
      });

    }

    private static Random _random = new Random();

    public static MovieQuote GetRandomQuote()
    {
      int rndValue = _random.Next(0, MovieQuotes.Count);
      return MovieQuotes[rndValue];
    }
  
  }

}
