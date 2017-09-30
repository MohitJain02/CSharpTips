Deletgates are immutable and will create a new object every time when you add or remove the method from the multicast delegate.
In case of mullticast delegates the target methods are called in the order in which they are added int the delegate.
 To assign one delegate to another we need to pass the one delegate to the constrcutor of another delegate which points to the same type of method as that of another delegate is expecting. 
In Case of struct if none of the fields of the current instance and obj are reference type then the equals method performs a byte-by-byte comparison of the  objects in memory.
Otherwise it uses the reflection to compare the corresponding fields of obj and this instance.
If you don't override the reference type equals method then by default values.eqauls methofd is being picked which uses the reflection to compare and takes huge amoint of time.
Important Point : If your vaue type contains fields that are reference types, you should override the equals(obj) method . this can improve and enable you to more closely represent the meaning of eqaulity for the type.
Short Ciruiting Operators are and && and or || operators and non short circuting operators are & and | operator.
If we want to hide the implementaiton of the interface then we can define the interface explictily inside the class which is implementing it . By doing this the memeber of that class will not be directly available to that instance of the class and to access that method we need to cast that instance of the class to that interface
We can use the System.io.Compression and System.Io.Compression.fileSystem to work with the zip files.
ZipFile methods CreateFromDirectory()
ExtractToDirectory(), Open(),
ZipArchiveMode.Update to update the zip files inside the zip folder.
By Default the Constructor of the URI assumes the path specified to be the absolute path and if you specify the relative path then it will throw an exception.
Lazy<> keyword initialization allow us to deferr the creation of the object until its first use or we access there resources. The Value prop of the Lazy<> is not a setter one and can not be setted
