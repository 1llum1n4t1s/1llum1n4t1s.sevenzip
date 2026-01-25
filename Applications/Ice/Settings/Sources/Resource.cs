/* ------------------------------------------------------------------------- */
//
// Copyright (c) 2010 CubeSoft, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
/* ------------------------------------------------------------------------- */
using Cube.FileSystem.SevenZip.Ice.Settings.Properties;
using Cube.Forms;
namespace Cube.FileSystem.SevenZip.Ice.Settings
{
    /* --------------------------------------------------------------------- */
    ///
    /// Surface
    ///
    /// <summary>
    /// Provides resources for display.
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    public static class Surface
    {
        #region Properties

        /* ----------------------------------------------------------------- */
        ///
        /// Shortcuts
        ///
        /// <summary>
        /// Gets the collection in which each item consists of a display
        /// string and a Preset pair.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public static ComboListSource<Preset> Shortcuts { get; } = new()
        {
            { Resources.MenuZip,         Preset.CompressZip },
            { Resources.MenuZipPassword, Preset.CompressZipPassword },
            { Resources.MenuSevenZip,    Preset.Compress7z },
            { Resources.MenuBZip2,       Preset.CompressBz2 },
            { Resources.MenuGZip,        Preset.CompressGz },
            { Resources.MenuSfx,         Preset.CompressSfx },
            { Resources.MenuDetails,     Preset.CompressDetails },
        };

        /* ----------------------------------------------------------------- */
        ///
        /// CompressionLevels
        ///
        /// <summary>
        /// Gets the collection in which each item consists of a display
        /// string and a CompressionLevel pair.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public static ComboListSource<CompressionLevel> CompressionLevels { get; } = new()
        {
            { Resources.LevelNone,   CompressionLevel.None },
            { Resources.LevelFast,   CompressionLevel.Fast },
            { Resources.LevelLow,    CompressionLevel.Low },
            { Resources.LevelNormal, CompressionLevel.Normal },
            { Resources.LevelHigh,   CompressionLevel.High },
            { Resources.LevelUltra,  CompressionLevel.Ultra },
        };

        /* ----------------------------------------------------------------- */
        ///
        /// IoHandlers
        ///
        /// <summary>
        /// Gets the collection in which each item consists of a display
        /// string and a bool pair.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public static ComboListSource<bool> IoHandlers { get; } = new()
        {
            { Resources.MenuNormal,   false },
            { Resources.MenuExtended,  true },
        };

        #endregion
    }
}
