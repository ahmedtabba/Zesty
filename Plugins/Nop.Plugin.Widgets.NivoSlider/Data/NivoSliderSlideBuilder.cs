using FluentMigrator.Builders.Create.Table;
using Nop.Data.Mapping.Builders;
using Nop.Plugin.Widgets.NivoSlider.Domain;

namespace Nop.Plugin.Widgets.NivoSlider.Data
{
    public class NivoSliderSlideBuilder : NopEntityBuilder<NivoSliderSlide>
    {
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(NivoSliderSlide.Text)).AsString(1000).Nullable()
                .WithColumn(nameof(NivoSliderSlide.Link)).AsString(1000).Nullable()
                .WithColumn(nameof(NivoSliderSlide.AltText)).AsString(500).Nullable()
                .WithColumn(nameof(NivoSliderSlide.CaptionHtml)).AsString(int.MaxValue).Nullable()
                .WithColumn(nameof(NivoSliderSlide.PictureId)).AsInt32().Nullable()
                .WithColumn(nameof(NivoSliderSlide.PictureProductId)).AsInt32().Nullable()
                .WithColumn(nameof(NivoSliderSlide.DisplayOrder)).AsInt32().WithDefaultValue(0)
                .WithColumn(nameof(NivoSliderSlide.IsActive)).AsBoolean().WithDefaultValue(true);
        }
    }
}