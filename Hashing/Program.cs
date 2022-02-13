using Hashing;

const int max = 100;
Hash hashTable = new Hash(max);

hashTable.Add(1);
hashTable.Add(101);
hashTable.Add(2);
hashTable.Add(3);

Console.WriteLine(hashTable.ToString());