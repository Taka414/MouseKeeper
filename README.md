# MouseKeeper

プレゼンスが退席中になるのを防止するツール/Tools to prevent presence from becoming absent.

## 動作環境/Operating environment

* Windows11
* .NET Framwework 4.8.1


## 使い方/usage

* ja
  * [ここからzipファイルをダウンロード](https://github.com/Taka414/MouseKeeper/releases/tag/1.2.0)し解凍します。
  * MouseKeeper.exe を実行します。
  * タスクトレイにマウスポインターのアイコンが表示されるとアプリケーションが動作しています。
  * アプリケーションを終了するにはタスクトレイのアイコンのコンテキストメニューから「終了(X)」を選択します。
* en
  * [Download](https://github.com/Taka414/MouseKeeper/releases/tag/1.2.0) the zip file from here and extract it
  * Run MouseKeeper.exe.
  * When the mouse pointer icon is displayed in the task tray, the application is running.
  * To quit the application, select "Quit (X)" from the context menu of the icon in the task tray.


## 説明

このツールはあなたがPC操作を1分中断すると、30秒ごとにOSに対しシグナルを送信し、PCを操作しているように見せかけます。技術的な詳細は以下リンクを参照ください。

This tool sends a signal to the OS every 30 seconds when you stop operating your PC for a minute, making it appear as if you are operating your PC. For technical details, please refer to the following link (in Japanese only)



[リンク/Link](https://takap-tech.com/entry/2021/12/17/234029)


## License

These codes are licensed under CC0.

[![CC0](http://i.creativecommons.org/p/zero/1.0/88x31.png "CC0")](http://creativecommons.org/publicdomain/zero/1.0/deed.ja)
