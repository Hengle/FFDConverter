# FFDConverter
FFDConverter is a tool used for creating custom bitmap fonts for AnvilNext, Dunia, Disrupt engine (Far Cry, Assassin's Creed, Watch Dogs games and more... )

## Installation

Donwload [lastest release](https://github.com/eprilx/FFDConverter/releases) and run FFDConverter.exe from command prompt.

## Building from source
- **[Install .NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)**
- ``git clone --recurse-submodules https://github.com/eprilx/FFDConverter.git``

## Usage

```
FFDConverter [OPTIONS]
Options:
  -v, --version=VALUE        (required) Name of game. (FC3,FC5,...)
  -f, --originalFFD=VALUE    (required) Original FFD file (*.ffd|*.Fire_Font_Descriptor)
  -b, --bmfontDesc=VALUE     (required) Character description file (*.fnt)
  -o, --NewFFD=VALUE         (optional) Output new FFD file
  -h, --help                 show this message and exit
```

```
Example: FFDConverter -v FC5 -f fcz_bold_default.ffd -b arialFC5.fnt -o fcz_bold_default.new.ffd
```
- fcz_bold_default.ffd is the file you get when unpack game files.
- arialFC5.fnt is a character descriptions file generated by [BMFont](https://www.angelcode.com/products/bmfont/) or [Hiero](https://github.com/libgdx/libgdx/wiki/Hiero)

*Note 1: After replace \*.ffd file, you need to replace image file in-game (\*.xbt from Far Cry series)*

If the font is displayed incorrectly in game, you should edit config.xml to be more compatible.
- scaleXadvance = 1.0

![1.0](sampleImg/1.0xadvance.png)
- scaleXadvance = 1.3

![1.3](sampleImg/1.3xadvance.png)

- addCustomYoffset = -3

![0Y](sampleImg/0Yoffset.png)
- addCustomYoffset = -10

![-10Y](sampleImg/Sub10Yoffset.png)
- scaleWidth = 12.0 and scaleHeight = 12.0

![scaleWH12](sampleImg/scaleWH12.png)

*Note 2: Make font more smoother without nasty pixel, try creating [signed distance field font with Hiero](https://github.com/libgdx/libgdx/wiki/Distance-field-fonts) or searching about ``signed distance field`` for more solution.*

## TODO
[Support more game.](https://github.com/eprilx/FFDConverter/issues/2)

## License
[MIT](LICENSE)
