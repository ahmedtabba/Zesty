# Copilot Instructions

## Project Guidelines
- NivoSlider slides: main image is used as background (first image), second image is the product image with class 'nivo-slide-product' and should be visible/positioned over the background.
  - Do not hide images with class 'nivo-slide-product' — the product image must remain visible above the main background image.
  - If the NivoSlider product image doesn't appear, position `.nivo-slide-product` relative to the slider container (not the anchor), override plugin inline hiding with `!important` on `display`, `visibility`, and `opacity`. If needed, change JavaScript to avoid hiding elements with class 'nivo-slide-product'.
  - When NivoSlider slides include a second image with class 'nivo-slide-product', the plugin should clone that image into the slider container and show it above the main image for the active slide (the plugin should not hide product overlays).