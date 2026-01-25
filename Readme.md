# 1llum1n4t1s.Sevenzip

**リポジトリ:** [https://github.com/1llum1n4t1s/1llum1n4t1s.Sevenzip](https://github.com/1llum1n4t1s/1llum1n4t1s.Sevenzip)

> **これは [Cube.FileSystem.SevenZip](https://github.com/cube-soft/cube.filesystem.sevenzip) のフォークです。** ソースコードは上記リポジトリで公開しています。  
> 元リポジトリとの主な違いは以下のとおりです。
> - **.NET 10** 対応（ターゲットを net10.0 / net10.0-windows に変更）
> - CI を AppVeyor から **GitHub Actions** に移行
> - NuGet パッケージ名を **1llum1n4t1s.Sevenzip** として公開
> - [Cube.Core](https://github.com/cube-soft/cube.core) や Cube.FileSystem.AlphaFS、Cube.Logging.NLog、Cube.Forms などを NuGet 参照ではなく **ソリューション内のプロジェクトとして組み込み**

---

[1llum1n4t1s.Sevenzip](https://github.com/1llum1n4t1s/1llum1n4t1s.Sevenzip) は [7-Zip](http://www.7-zip.org/) の COM インターフェースを利用したラッパーライブラリです。アーカイブの圧縮・解凍を行う [CubeICE](https://www.cube-soft.jp/cubeice/) アプリケーションも含みます。ライブラリおよびアプリケーションは .NET 10 をターゲットとしています。ライセンスはプロジェクトにより GNU LGPLv3 または Apache 2.0 です。詳細は [License.md](https://github.com/1llum1n4t1s/1llum1n4t1s.Sevenzip/blob/main/License.md) を参照してください。

## Usage

NuGet パッケージでインストールできます。パッケージ ID は **1llum1n4t1s.Sevenzip** です。プロジェクトファイルに依存関係を追加するか、Visual Studio の NuGet パッケージ UI から選択してください。ソースからビルドする場合は [リポジトリ](https://github.com/1llum1n4t1s/1llum1n4t1s.Sevenzip) をクローンしてください。

### Examples for archiving files

圧縮の簡単な例は以下のとおりです。サンプルでは `using Cube.FileSystem.SevenZip;` は省略しています。

```cs
// Set only what you need.
var files   = new[] { ".DS_Store", "Thumbs.db", "__MACOSX", "desktop.ini" };
var options = new CompressionOption
{
    CompressionLevel  = CompressionLevel.Ultra,
    CompressionMethod = CompressionMethod.Lzma,
    EncryptionMethod  = EncryptionMethod.Aes256,
    Password          = "password",
    Filter            = Filter.From(files),
    CodePage          = CodePage.Utf8,
};

using (var writer = new ArchiveWriter(Format.Zip, options))
{
    writer.Add(@"path\to\file");
    writer.Add(@"path\to\directory_including_files");

    var progress = new Progress<Report>(e => DoSomething(e));
    writer.Save(@"path\to\save.zip", progress);
}
```

ArchiveWriter にアーカイブ形式（Zip, SevenZip など）とオプションを指定し、追加したいファイル・ディレクトリを Add したうえで Save を呼び出します。Tar 系のアーカイブでは TarOption で圧縮方式（GZip, BZip2, XZ, Copy）を指定できます。

```cs
var options = new CompressionOption
{
    CompressionLevel  = CompressionLevel.Ultra,
    CompressionMethod = CompressionMethod.BZip2, // GZip, BZip2, XZ or Copy
};

using (var writer = new ArchiveWriter(Format.Tar, options))
{
    writer.Add(@"path\to\file");
    writer.Add(@"path\to\directory_including_files");
    writer.Save(@"path\to\save.tar.gz");
}
```

### Examples for extracting archives

アーカイブを解凍するには ArchiveReader を作成し、Save を呼び出します。コンストラクタの第2引数（パスワード）には文字列または `Cube.Query<string>` を指定できます。後者は対話的にパスワードを求める場合に利用します。

```cs
// Set password directly or using Query<string>
var password = new Cube.Query<string>(e =>
{
    e.Result = "password";
    e.Cancel = false;
});

// Supports only the Filter property
var files   = new[] { ".DS_Store", "Thumbs.db", "__MACOSX", "desktop.ini" };
var options = new ArchiveOption { Filter = Filter.From(files) };

using (var reader = new ArchiveReader(@"path\to\archive", password, options))
{
    var progress = new Progress<Report>(e => DoSomething(e));
    reader.Save(@"path\to\directory", progress);
}
```

ArchiveWriter および ArchiveReader は、生成から破棄まで同一スレッドで実行する必要があります。非同期に圧縮・解凍したい場合は、一連の処理全体を `Task.Run()` で実行してください。

## Dependencies

* [7-Zip](https://www.7-zip.org/) … [Cube.Native.SevenZip](https://github.com/cube-soft/Cube.Native.SevenZip) は日本語エンコーディングに最適化されています。
* [AlphaFS](https://alphafs.alphaleonis.com/) … 本ソリューション内の Cube.FileSystem.AlphaFS プロジェクトが AlphaFS をラップしています（長いパス対応など）。

## License

[本リポジトリ](https://github.com/1llum1n4t1s/1llum1n4t1s.Sevenzip) は次のオリジナルプロジェクトをベースにしています。

| 由来 | リポジトリ | ライセンス |
|------|------------|------------|
| 7-Zip ラッパー・CubeICE | [cube-soft/cube.filesystem.sevenzip](https://github.com/cube-soft/cube.filesystem.sevenzip) | コアライブラリ: [GNU LGPLv3](https://www.gnu.org/licenses/lgpl-3.0.html)、その他: [Apache 2.0](https://www.apache.org/licenses/LICENSE-2.0) |
| ユーティリティ・MVVM 等 | [cube-soft/cube.core](https://github.com/cube-soft/cube.core) | [Apache 2.0](https://www.apache.org/licenses/LICENSE-2.0) |

各プロジェクトのライセンス表記および条件は、本リポジトリ内の [License.md](https://github.com/1llum1n4t1s/1llum1n4t1s.Sevenzip/blob/main/License.md) およびソリューション内の各ライセンスファイルを参照してください。  
Copyright © 2010 [CubeSoft, Inc.](https://www.cube-soft.jp/)

Copyright © 2026 [ゆろち](https://github.com/1llum1n4t1s/)
