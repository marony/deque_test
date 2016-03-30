# C#の`List<T>`と`Queue<T>`の速度比較

## 説明

　C#(.Net Framework 4.5.2)の`List<T>`と`Queue<T>`を1億回後ろに追加し先頭を削除を繰り返してみました。  

　文字列(参照型)のため`List<T>`でもオブジェクトのコピーは速いだろうと想像したのですが思ったよりも速度差がありました。`Queue<T>`の実装を見てみたところリングバッファになっているようで要素を追加してもノードオブジェクトのようなものは作られないのですね。  

[queue.cs](http://referencesource.microsoft.com/#mscorlib/system/collections/queue.cs "queue.cs")

## 結果

List<T>での結果:  
3226 millis  

Queue<T>での結果:  
2295 millis  

1億回もコレクションに追加したり削除したりする機会はなかなかないと思いますが参考まで。
