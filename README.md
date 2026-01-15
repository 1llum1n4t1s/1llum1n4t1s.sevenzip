# ILLUMINATI.SevenZip

ILLUMINATI.SevenZip は、7-Zip の機能を .NET から扱うためのラッパーライブラリです。`ArchiveWriter`/`ArchiveReader` を中心に、圧縮・解凍、SFX（自己解凍形式）作成、進捗通知などの API を提供します。主要なライブラリは `net10.0-windows` を対象にしており、内部で Cube.Native.SevenZip を利用します。【F:Libraries/Core/ILLUMINATI.SevenZip.csproj†L1-L26】

本リポジトリには Windows 用の圧縮・解凍アプリケーション「CubeICE」も含まれています。CubeICE の詳細はアプリ側の Readme を参照してください。【F:Applications/Ice/Readme.md†L1-L33】

## 主な機能

- **アーカイブ作成**: `ArchiveWriter` でファイル/フォルダーを追加し、`Save` でアーカイブを生成します。SFX（`Format.Sfx`）や Tar（`Format.Tar`）は専用処理を通ります。【F:Libraries/Core/Sources/ArchiveWriter.cs†L33-L155】
- **アーカイブ解凍**: `ArchiveReader` でアーカイブを開き、`Save` で展開します。`dest` を空にするとテストモードで実行されます。【F:Libraries/Core/Sources/ArchiveReader.cs†L25-L296】
- **フォーマット検出**: `FormatFactory` がファイルの先頭シグネチャや拡張子から形式を推定します。【F:Libraries/Core/Sources/FormatFactory.cs†L33-L166】
- **圧縮/解凍オプション**: スレッド数、コードページ、フィルタ、圧縮レベル、暗号方式、パスワードを指定できます。【F:Libraries/Core/Sources/Options/ArchiveOption.cs†L33-L82】【F:Libraries/Core/Sources/Options/CompressionOption.cs†L19-L72】【F:Libraries/Core/Sources/Filter.cs†L19-L45】
- **進捗通知**: `IProgress<Report>` で状態、処理件数/バイト数、例外などを受け取れます。【F:Libraries/Core/Sources/Report.cs†L19-L105】

## 対応フォーマット（抜粋）

`Format` 列挙体で多数の形式を扱えます。代表例として以下のフォーマットが定義されています。

- 7z, Zip, Tar, GZip, BZip2, XZ, Lzh, Rar, Zstd, Cab など【F:Libraries/Core/Sources/Format.cs†L21-L116】

## 使い方

以下は最小構成の例です。必要に応じて `CompressionOption` や `ArchiveOption` を調整してください。

### 圧縮

```cs
using ILLUMINATI.SevenZip;

var options = new CompressionOption
{
    CompressionLevel  = CompressionLevel.Ultra,
    CompressionMethod = CompressionMethod.Lzma,
    EncryptionMethod  = EncryptionMethod.Aes256,
    Password          = "password",
    CodePage          = CodePage.Utf8,
    Filter            = Filter.From(new[] { ".DS_Store", "Thumbs.db" }),
};

using var writer = new ArchiveWriter(Format.Zip, options);
writer.Add(@"path\\to\\file");
writer.Add(@"path\\to\\directory");
writer.Save(@"path\\to\\archive.zip");
```

`ArchiveWriter` は `Format.Sfx` と `SfxOption` を組み合わせて自己解凍形式の生成にも対応します。【F:Libraries/Core/Sources/ArchiveWriter.cs†L33-L155】【F:Libraries/Core/Sources/Options/SfxOption.cs†L19-L46】

### 解凍

```cs
using ILLUMINATI.SevenZip;

var options = new ArchiveOption
{
    Filter = Filter.From(new[] { ".DS_Store", "Thumbs.db" }),
};

using var reader = new ArchiveReader(@"path\\to\\archive.7z", "password", options);
reader.Save(@"path\\to\\output");
```

`ArchiveReader` はファイルの中身を `Items` で参照でき、`Save` に進捗通知用の `IProgress<Report>` を渡すこともできます。【F:Libraries/Core/Sources/ArchiveReader.cs†L33-L296】

## 開発メモ

- `FormatFactory.From(...)` によりシグネチャまたは拡張子で形式判定を行います。【F:Libraries/Core/Sources/FormatFactory.cs†L33-L166】
- `ArchiveOption`/`CompressionOption` の設定内容は一部のフォーマットにのみ適用されます。【F:Libraries/Core/Sources/Options/CompressionOption.cs†L19-L36】

## ライセンス

- ライブラリ（Core）は LGPL v3
- その他のプロジェクトは Apache 2.0

詳細は `License.md` を参照してください。【F:License.md†L1-L6】

## 連絡先

- 名前: ゆろち
- 連絡先: https://github.com/1llum1n4t1s
