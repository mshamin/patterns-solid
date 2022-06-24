# patterns/solid
A simple project to describe SOLID patterns highly promoted by Robert C Martin

## SOLID
https://en.wikipedia.org/wiki/SOLID

| Letter    | Full Name     | Description                | Example                |
| :-------- | :-------      | :------------------------- | :------------------------- |
| `S` | `single-responsibility principle`    | Every class should have only one responsibility. | class CommandPrompt only reads and writes to console. |
| `O` | `open-closed principle`              | Objects are open for extension and closed for modification. |  We can extend MaxNumberGameOptions class with another interface, but we can't modify its private fields |
| `L` | `Liskov substitution principle`      | Functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it. | CommandPrompt class Inherits IDataReader and IDataWriter therefore we can use it as input parameter in GameMaster |
| `I` | `interface segregation principle`    | Many client-specific interfaces are better than one general-purpose interface. | Instead of making complex console interface it is composed from IDataReader and IDataWriter |
| `D` | `dependency inversion principle`     | Depend upon abstractions, [not] concretions. | GameMaster takes interfaces as input parameters |