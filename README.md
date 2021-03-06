# smeerws-ConcreteSingleton

A singleton is a design pattern.
The implementation of a singleton design pattern within a class ensures that *only one* instance of the object 
ever exists at any one time. 
There exist several different singleton implementations. 

The concrete singleton inherits from the GenericSingleton (a singleton without copying code), 
the GenericSingleton fixes the persistency problem and allows lazy instantiation.  

+ Link to [SimpleSingleton](https://github.com/HS-Teaching/smeerws-SimpleSingleton)
+ Link to [PersistentSingleton](https://github.com/HS-Teaching/smeerws-PersistentSingleton)
+ Link to [LazySingleton](https://github.com/HS-Teaching/smeerws-LazySingleton)

The singleton design pattern can be used for saving data between scenes. 
Use singletons for controller classes such as GameManager, GameController, etc. where it is important that an instance 
exists only once. 

Dev-platform: Win 10, Unity Version: 2018.2.14f1, Visual Studio Version: VS Community 2017, 15.3.9;
Scripting Runtime Version: .NET 4.x Equivalent
API Compatibility Level: .NET Standard 2.0

Target platform: Standalone (Reference Resolution: 1024 x 768)