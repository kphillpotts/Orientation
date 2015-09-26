using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XfOrientation.Views
{
  public static class FontSizeHelper
  {

    public static int CalculateFontSize(string text, double viewWidth, double viewHeight)
    {
      // Two values as multiples of font size         
      double lineHeight = Device.OnPlatform(1.2, 1.2, 1.3);
      double charWidth = 0.5;

      // Format the text and get its length         
      text = String.Format(text, lineHeight, charWidth, viewWidth, viewHeight);
      int charCount = text.Length;

      // Because:         
      //   lineCount = view.Height / (lineHeight * fontSize)         
      //   charsPerLine = view.Width / (charWidth * fontSize)         
      //   charCount = lineCount * charsPerLine         
      // Hence, solving for fontSize:         
      int fontSize = (int) Math.Sqrt(viewWidth*viewHeight/
                                     (charCount*lineHeight*charWidth));

      // Now these values can be calculated.         
      int lineCount = (int) (viewHeight/(lineHeight*fontSize));
      int charsPerLine = (int) (viewWidth/(charWidth*fontSize));

      return fontSize;

    }
  }
}
