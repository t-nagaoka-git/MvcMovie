## 参考

- [ASP.NET Core 5.0 MVC のチュートリアルを丁寧にやってみた ①（プロジェクトの作成からビューの追加まで）](https://hirahira.blog/asp-net-core5-mvc-tutorial-01/)
- [ASP.NET Core 5.0 MVC のチュートリアルを丁寧にやってみた ②（モデルの追加と DB の作成）](https://hirahira.blog/asp-net-core5-mvc-tutorial-02/)
- [ASP.NET Core 5.0 MVC のチュートリアルを丁寧にやってみた ③（タグヘルパーの確認や検索機能の追加など）](https://hirahira.blog/asp-net-core5-mvc-tutorial-03/)
- [ASP.NET Core 5.0 MVC のチュートリアルを丁寧にやってみた ④（プロパティと検証属性の追加）](https://hirahira.blog/asp-net-core5-mvc-tutorial-04/)

## 目次

- Chapter1
  - 本記事の対象
  - 環境
  - 準備と新規プロジェクトの作成
  - コントローラーの追加
    - ※クエリ文字列とは？
    - ※モデルバインドシステムとは？
  - ビューの追加
    - Razor テンプレートの呼び出し
    - テンプレートの追加
    - 共通レイアウト
    - コントローラーからビューへデータを渡す
      - ViewData とは
- Chapter2
  - Entity Framework Core を使ったモデルの追加
    - EFCore のインストール
    - データモデルクラスの定義
    - コンテキストクラスの作成と登録
    - 接続文字列の追加
  - スキャフォールディング
  - マイグレーション
  - アプリを実行して CRUD 操作を試す
  - コントローラーからビューにモデルを渡す流れを確認
  - テーブルの中身を確認
  - まとめ
- Chapter3
  - タグヘルパー
  - POST リクエストの処理
    - HttpPost 属性
    - ValidateAntiForgeryToken 属性
    - Bind 属性
    - ModelState.IsValid と SaveChangesAsync
  - 検索機能の追加
  - ジャンルによる検索機能の追加
  - まとめ
- Chapter4
  - Movie モデルに新しいプロパティの追加
  - Entity Framework Core コードファーストを実行
  - 検証属性の追加
  - まとめ
