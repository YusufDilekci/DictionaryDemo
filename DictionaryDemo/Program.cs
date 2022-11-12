//EXAMPLE 1

//Dictionary<int, string> letters = new Dictionary<int, string>(){
//             {1,"A"},
//             {2,"B"},
//             {3,"C"},
//         };

//Console.WriteLine(letters.Count);

//Console.WriteLine(letters[1]);

//foreach (var letter in letters)
//{
//    Console.WriteLine("Key : {0}  Value : {1}", letter.Key, letter.Value);
//}


//EXAMPLE 2

//var cities = new Dictionary<string, string>(){
//            {"UK","London, Manchester, Birmingham"},
//            {"USA","Chicago, New York, Washington"},
//            {"India","Mumbai, New Delhi, Pune"}
//        };

//foreach (var kvp in cities)
//    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);



// ******* EXAMPLE 3 ********

MyDictionary<int, string> dict = new MyDictionary<int, string>();
dict.Add(1, "A");
dict.Add(2, "B");
dict.Add(3, "C");

Console.WriteLine(dict.ElementAt(1).Value);
Console.WriteLine(dict.Count);

for(int i=0; i<dict.Count; i++)
{
    Console.WriteLine($"Key : {dict.ElementAt(i).Key}  Value: {dict.ElementAt(i).Value}");
}

class MyDictionary<K,V>
{
    K[] _keyArray;
    V[] _valueArray;
    K[] _tempKeyArray;
    V[] _tempValueArray;

    public MyDictionary()
    {
        _keyArray = new K[0];
        _valueArray = new V[0];
    }
    public void Add(K key, V value)
    {
        _tempKeyArray = _keyArray;
        _tempValueArray = _valueArray;
        _keyArray = new K[_keyArray.Length+1];
        _valueArray = new V[_valueArray.Length+1];

        for(int i=0; i<_tempKeyArray.Length; i++) 
        {
            _keyArray[i] = _tempKeyArray[i];
            _valueArray[i] = _tempValueArray[i];
        }
        _keyArray[_keyArray.Length-1] = key;
        _valueArray[_valueArray.Length-1] = value;
    }

    public (K Key, V Value) ElementAt(int i)
    {
        return (_keyArray[i], _valueArray[i]);
    }
    public int Count { get { return _keyArray.Length; }}

}