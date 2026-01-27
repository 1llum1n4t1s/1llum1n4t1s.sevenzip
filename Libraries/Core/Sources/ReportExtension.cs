/* ------------------------------------------------------------------------- */
//
// Copyright (c) 2010 CubeSoft, Inc.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
/* ------------------------------------------------------------------------- */
using System;
namespace Cube.FileSystem.SevenZip;

/* ------------------------------------------------------------------------- */
///
/// ReportExtension
///
/// <summary>
/// Provides extended methods of the Report class.
/// </summary>
///
/* ------------------------------------------------------------------------- */
public static class ReportExtension
{
    /* --------------------------------------------------------------------- */
    ///
    /// PrepareWeightRatio
    ///
    /// <summary>
    /// Gets the weight ratio for Prepare stage (0.0 to 1.0).
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    public static readonly double PrepareWeightRatio = 0.1;

    /* --------------------------------------------------------------------- */
    ///
    /// ProgressWeightRatio
    ///
    /// <summary>
    /// Gets the weight ratio for Progress stage (1.0 - PrepareWeightRatio).
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    private static double ProgressWeightRatio => 1.0 - PrepareWeightRatio;

    /* --------------------------------------------------------------------- */
    ///
    /// GetRatio
    ///
    /// <summary>
    /// Gets the progress ratio within the range of [0, 1].
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    public static double GetRatio(this Report src) {
        if (src.State == ProgressState.Prepare)
        {
            var c1 = src.TotalCount > 0 ? src.Count / (double)src.TotalCount : 0.0;
            return c1 * PrepareWeightRatio;
        }

        if (src.State == ProgressState.Progress)
        {
            var c0 = src.TotalBytes > 0 ? src.Bytes / (double)src.TotalBytes : 0.0;
            return PrepareWeightRatio + (c0 * ProgressWeightRatio);
        }

        var c0_orig = src.TotalBytes > 0 ? src.Bytes / (double)src.TotalBytes : 0.0;
        var c1_orig = src.TotalCount > 0 ? src.Count / (double)src.TotalCount : 0.0;

        return src.TotalBytes <=   0 ? c1_orig :
               src.TotalCount <  100 ? c0_orig : Math.Min(c0_orig, c1_orig);
    }
}
