using Xamarin.Forms;

namespace XfOrientation.Views
{
  public partial class ComplimentaryLayoutPage : BaseContentPage
  {
    private readonly MovieQuote _movieQuote;
    private LandscapeContent _landscape;
    private TabletLandscapeContent _tabletLandscape;
    private PortraitContent _portrait;

    public ComplimentaryLayoutPage(MovieQuote movieQuote)
    {
      InitializeComponent();
      _movieQuote = movieQuote;
    }

    protected override void OnOrientationChanged(OrientationValue newOrientation)
    {
      Content = newOrientation == OrientationValue.Portrait ? GetPortraitView() : GetLandscapeView();
    }

    private View GetPortraitView()
    {
      if (_portrait == null) 
        _portrait = new PortraitContent(_movieQuote);
      return _portrait;
    }

    private View GetLandscapeView()
    {
      if (Device.Idiom == TargetIdiom.Tablet)
      {
        if (_tabletLandscape == null)
          _tabletLandscape = new TabletLandscapeContent(_movieQuote);
        return _tabletLandscape;
      }
      else
      {
        if (_landscape == null)
          _landscape = new LandscapeContent(_movieQuote);
        return _landscape;
      }
    }

  }
}