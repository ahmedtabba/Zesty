// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders.SliderListModel
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Nop.Web.Framework.Models;
using System.Runtime.CompilerServices;
using System.Text;

#nullable enable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders;

public record SliderListModel() : BasePagedListModel<
#nullable disable
SliderModel>
{
  [CompilerGenerated]
  public virtual 
  #nullable enable
  string ToString()
  {
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append(nameof (SliderListModel));
    stringBuilder.Append(" { ");
    if (((BaseNopModel) this).PrintMembers(stringBuilder))
      stringBuilder.Append(' ');
    stringBuilder.Append('}');
    return stringBuilder.ToString();
  }

  [CompilerGenerated]
  protected virtual bool PrintMembers(StringBuilder builder) => base.PrintMembers(builder);

  [CompilerGenerated]
  public virtual int GetHashCode() => base.GetHashCode();

  [CompilerGenerated]
  public virtual bool Equals(BasePagedListModel<
  #nullable disable
  SliderModel>
  #nullable enable
  ? other) => ((object) this).Equals((object) other);

  [CompilerGenerated]
  public virtual bool Equals(SliderListModel? other)
  {
    return (object) this == (object) other || base.Equals((BasePagedListModel<SliderModel>) other);
  }
}
