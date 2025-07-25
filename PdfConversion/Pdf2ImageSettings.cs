// Decompiled with JetBrains decompiler
// Type: Cyotek.GhostScript.PdfConversion.Pdf2ImageSettings
// Assembly: Cyotek.GhostScript.PdfConversion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F846869A-603F-4B14-A759-B0D0C54D84D2
// Assembly location: D:\Proyectos\Matika\ModelosGX\MatikaErp_Up\CSharpModel\web\bin\Cyotek.GhostScript.PdfConversion.dll

using System.ComponentModel;

#nullable disable
namespace Cyotek.GhostScript.PdfConversion;

[TypeConverter(typeof (ExpandableObjectConverter))]
public class Pdf2ImageSettings : INotifyPropertyChanged
{
  private AntiAliasMode _antiAliasMode;
  private int _dpi;
  private GridFitMode _gridFitMode;
  private ImageFormat _imageFormat;
  private PaperSize _paperSize;
  private PdfTrimMode _trimMode;

  public Pdf2ImageSettings()
  {
    this.Dpi = 150;
    this.GridFitMode = GridFitMode.Topological;
    this.AntiAliasMode = AntiAliasMode.High;
    this.ImageFormat = ImageFormat.Jpeg;
    this.PaperSize = PaperSize.Default;
    this.TrimMode = PdfTrimMode.CropBox;
  }

  public event PropertyChangedEventHandler PropertyChanged;

  [DefaultValue(typeof (AntiAliasMode), "High")]
  public AntiAliasMode AntiAliasMode
  {
    get => this._antiAliasMode;
    set
    {
      if (this.AntiAliasMode == value)
        return;
      this._antiAliasMode = value;
      this.OnPropertyChanged(new PropertyChangedEventArgs(nameof (AntiAliasMode)));
    }
  }

  [DefaultValue(150)]
  public int Dpi
  {
    get => this._dpi;
    set
    {
      if (this.Dpi == value)
        return;
      this._dpi = value;
      this.OnPropertyChanged(new PropertyChangedEventArgs(nameof (Dpi)));
    }
  }

  [DefaultValue(typeof (GridFitMode), "Topological")]
  public GridFitMode GridFitMode
  {
    get => this._gridFitMode;
    set
    {
      if (this.GridFitMode == value)
        return;
      this._gridFitMode = value;
      this.OnPropertyChanged(new PropertyChangedEventArgs(nameof (GridFitMode)));
    }
  }

  [DefaultValue(typeof (ImageFormat), "Jpeg")]
  public ImageFormat ImageFormat
  {
    get => this._imageFormat;
    set
    {
      if (this.ImageFormat == value)
        return;
      this._imageFormat = value;
      this.OnPropertyChanged(new PropertyChangedEventArgs(nameof (ImageFormat)));
    }
  }

  [DefaultValue(typeof (PaperSize), "Default")]
  public PaperSize PaperSize
  {
    get => this._paperSize;
    set
    {
      if (this.PaperSize == value)
        return;
      this._paperSize = value;
      this.OnPropertyChanged(new PropertyChangedEventArgs(nameof (PaperSize)));
    }
  }

  [DefaultValue(typeof (PdfTrimMode), "CropBox")]
  public PdfTrimMode TrimMode
  {
    get => this._trimMode;
    set
    {
      if (this.TrimMode == value)
        return;
      this._trimMode = value;
      this.OnPropertyChanged(new PropertyChangedEventArgs(nameof (TrimMode)));
    }
  }

  protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
  {
    if (this.PropertyChanged == null)
      return;
    this.PropertyChanged((object) this, e);
  }
}
