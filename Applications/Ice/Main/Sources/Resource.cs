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
using Cube.FileSystem.SevenZip.Ice.Properties;
using Cube.Forms;
using System;
using System.Collections.Generic;
namespace Cube.FileSystem.SevenZip.Ice
{
    /* --------------------------------------------------------------------- */
    ///
    /// Resource
    ///
    /// <summary>
    /// Provides resources for display.
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    public static class Resource
    {
        #region Properties

        /* ----------------------------------------------------------------- */
        ///
        /// Formats
        ///
        /// <summary>
        /// Gets the collection in which each item consists of a display
        /// string and a Format pair.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public static ComboListSource<Format> Formats { get; } = new()
        {
            { "Zip", Format.Zip },
            { "7z",  Format.SevenZip },
            { "Tar", Format.Tar },
            { Resources.FormatSfx, Format.Sfx },
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
        /// CompressionMethods
        ///
        /// <summary>
        /// Gets the collection in which each item consists of a display
        /// string and a CompressionMethod pair.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public static Dictionary<Format, ComboListSource<CompressionMethod>> CompressionMethods { get; } = new()
        {
            {
                Format.Zip, new()
                {
                    { "Deflate",   CompressionMethod.Default },
                    { "Deflate64", CompressionMethod.Deflate64 },
                    { "BZip2",     CompressionMethod.BZip2 },
                    { "LZMA",      CompressionMethod.Lzma },
                    { "PPMd",      CompressionMethod.Ppmd },
                    { "Copy",      CompressionMethod.Copy },
                }
            },
            {
                Format.SevenZip, new()
                {
                    { "LZMA",      CompressionMethod.Default },
                    { "LZMA2",     CompressionMethod.Lzma2 },
                    { "PPMd",      CompressionMethod.Ppmd },
                    { "BZip2",     CompressionMethod.BZip2 },
                    { "Deflate",   CompressionMethod.Deflate },
                    { "Copy",      CompressionMethod.Copy },
                }
            },
            {
                Format.Tar, new()
                {
                    { "GZip",      CompressionMethod.GZip },
                    { "BZip2",     CompressionMethod.BZip2 },
                    { "XZ",        CompressionMethod.XZ },
                    { "Copy",      CompressionMethod.Default },
                }
            },
            {
                Format.Sfx, new()
                {
                    { "LZMA",      CompressionMethod.Default },
                    { "LZMA2",     CompressionMethod.Lzma2 },
                    { "PPMd",      CompressionMethod.Ppmd },
                    { "BZip2",     CompressionMethod.BZip2 },
                    { "Deflate",   CompressionMethod.Deflate },
                    { "Copy",      CompressionMethod.Copy },
                }
            }
        };

        /* ----------------------------------------------------------------- */
        ///
        /// EncryptionMethods
        ///
        /// <summary>
        /// Gets the collection in which each item consists of a display
        /// string and an EncryptionMethod pair.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public static ComboListSource<EncryptionMethod> EncryptionMethods { get; } = new()
        {
            { "ZipCrypto", EncryptionMethod.ZipCrypto },
            { "AES128",    EncryptionMethod.Aes128 },
            { "AES192",    EncryptionMethod.Aes192 },
            { "AES256",    EncryptionMethod.Aes256 },
        };

        /* ----------------------------------------------------------------- */
        ///
        /// FileDialogFilters
        ///
        /// <summary>
        /// Gets the collection in which each item consists of a Format
        /// and a FileDialogFilter pair.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public static Collections.OrderedDictionary<Format, FileDialogFilter> FileDialogFilters { get; } = new()
        {
            { Format.Zip,      new(Resources.FilterZip, ".zip") },
            { Format.SevenZip, new(Resources.Filter7z,  ".7z") },
            { Format.Tar,      new(Resources.FilterTar, ".tar") },
            { Format.GZip,     new(Resources.FilterGz,  ".tar.gz", ".tgz") },
            { Format.BZip2,    new(Resources.FilterBz2, ".tar.bz2", ".tar.bz", ".tbz2", ".tb2", ".tbz") },
            { Format.XZ,       new(Resources.FilterXz,  ".tar.xz", ".txz") },
            { Format.Sfx,      new(Resources.FilterSfx, ".exe") },
            { Format.Unknown,  new(Resources.FilterAll, ".*") },
        };

        #endregion

        #region Methods

        /* ----------------------------------------------------------------- */
        ///
        /// GetCompressionMethods
        ///
        /// <summary>
        /// Gets the list of CompressionMethods and their display strings
        /// that are supported by the specified compressed file format.
        /// </summary>
        ///
        /// <param name="src">Archive format.</param>
        ///
        /// <returns>
        /// Correspondence between display strings and CompressionMethod
        /// objects.
        /// </returns>
        ///
        /* ----------------------------------------------------------------- */
        public static ComboListSource<CompressionMethod> GetCompressionMethods(Format src) =>
            CompressionMethods.TryGetValue(src, out var dest) ? dest : null;

        /* ----------------------------------------------------------------- */
        ///
        /// GetDialogFilters
        ///
        /// <summary>
        /// Gets the collection of the DialogFilter objects corresponding
        /// to the specified format.
        /// </summary>
        ///
        /// <param name="src">Archive format.</param>
        ///
        /// <returns>Extension filter.</returns>
        ///
        /* ----------------------------------------------------------------- */
        public static IEnumerable<FileDialogFilter> GetDialogFilters(Format src)
        {
            if (src == Format.Unknown) return FileDialogFilters.Values;
            var all = FileDialogFilters[Format.Unknown];
            return FileDialogFilters.TryGetValue(src, out var dest) ?
                   new[] { dest, all } :
                   new[] { all };
        }

        /* ----------------------------------------------------------------- */
        ///
        /// GetTimeString
        ///
        /// <summary>
        /// Gets the display string corresponding to the specified TimeSpan
        /// object.
        /// </summary>
        ///
        /// <param name="src">Date time.</param>
        ///
        /// <returns>Formatted string.</returns>
        ///
        /* ----------------------------------------------------------------- */
        public static string GetTimeString(TimeSpan src) =>
            $"{(int)src.TotalHours:00}:{src.Minutes:00}:{src.Seconds:00}";

        #endregion
    }
}
