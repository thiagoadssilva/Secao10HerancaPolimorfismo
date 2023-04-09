# Herança e polimorfismo no c#

### Em C#, herança é um conceito fundamental de Orientação a Objetos que permite criar novas classes a partir de classes existentes. Quando uma classe é herdada por outra, a nova classe herda os membros (campos, métodos e propriedades) da classe base e pode adicionar novos membros ou alterar o comportamento dos membros herdados. Para definir uma classe derivada em C#, use a palavra-chave class seguida pelo nome da nova classe e a palavra-chave :, seguida do nome da classe base. Por exemplo:

    class Animal {
    public void Eat() {
        Console.WriteLine("The animal is eating.");
    }
    }

    class Dog : Animal {
    public void Bark() {
        Console.WriteLine("Woof!");
    }
    }

### Nesse exemplo, a classe Dog herda da classe Animal e adiciona o método Bark(). Isso significa que um objeto da classe Dog também terá o método Eat() da classe base.
Polimorfismo é outro conceito importante de Orientação a Objetos em C#. O polimorfismo permite que um objeto seja tratado como se fosse de um tipo diferente, mas ainda mantendo seu comportamento original. Isso significa que um objeto pode ser usado como uma instância de sua classe base ou de qualquer uma de suas classes derivadas.
Por exemplo, considerando o exemplo anterior:

    Animal myDog = new Dog();
    myDog.Eat(); // imprime "The animal is eating."
    ((Dog)myDog).Bark(); // imprime "Woof!"

### Nesse exemplo, myDog é uma instância da classe Dog, mas é declarado como uma variável do tipo Animal. Isso significa que ele pode ser tratado como um Animal, mas ainda mantém seu comportamento original de Dog. Para chamar o método Bark(), é necessário fazer um cast para o tipo Dog. O polimorfismo também pode ser usado com interfaces em C#. Uma interface é uma coleção de membros que uma classe pode implementar para fornecer um comportamento específico. Quando uma classe implementa uma interface, ela é obrigada a implementar todos os membros da interface. Isso permite que um objeto seja tratado como uma instância da interface, independentemente da classe concreta que o implementa.

    Por exemplo:

    interface IAnimal {
    void Eat();
    }

    class Dog : IAnimal {
    public void Eat() {
        Console.WriteLine("The dog is eating.");
    }

    public void Bark() {
        Console.WriteLine("Woof!");
    }
    }

    IAnimal myDog = new Dog();
    myDog.Eat(); // imprime "The dog is eating.”

### Nesse exemplo, a classe Dog implementa a interface IAnimal. Isso significa que um objeto da classe Dog pode ser tratado como uma instância de IAnimal, independentemente de sua classe concreta. A chamada do método Eat() do objeto myDog imprimirá "The dog is eating." ao invés de "The animal is eating.", que seria impresso se o objeto fosse tratado como uma instância da classe base Animal.
