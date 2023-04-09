# Herança e polimorfismo no c#

Em C#, herança é um conceito fundamental de Orientação a Objetos que permite criar novas classes a partir de classes existentes. Quando uma classe é herdada por outra, a nova classe herda os membros (campos, métodos e propriedades) da classe base e pode adicionar novos membros ou alterar o comportamento dos membros herdados. Para definir uma classe derivada em C#, use a palavra-chave class seguida pelo nome da nova classe e a palavra-chave :, seguida do nome da classe base. Por exemplo:

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

Nesse exemplo, a classe Dog herda da classe Animal e adiciona o método Bark(). Isso significa que um objeto da classe Dog também terá o método Eat() da classe base.
Polimorfismo é outro conceito importante de Orientação a Objetos em C#. O polimorfismo permite que um objeto seja tratado como se fosse de um tipo diferente, mas ainda mantendo seu comportamento original. Isso significa que um objeto pode ser usado como uma instância de sua classe base ou de qualquer uma de suas classes derivadas.
Por exemplo, considerando o exemplo anterior:

    Animal myDog = new Dog();
    myDog.Eat(); // imprime "The animal is eating."
    ((Dog)myDog).Bark(); // imprime "Woof!"

Nesse exemplo, myDog é uma instância da classe Dog, mas é declarado como uma variável do tipo Animal. Isso significa que ele pode ser tratado como um Animal, mas ainda mantém seu comportamento original de Dog. Para chamar o método Bark(), é necessário fazer um cast para o tipo Dog. O polimorfismo também pode ser usado com interfaces em C#. Uma interface é uma coleção de membros que uma classe pode implementar para fornecer um comportamento específico. Quando uma classe implementa uma interface, ela é obrigada a implementar todos os membros da interface. Isso permite que um objeto seja tratado como uma instância da interface, independentemente da classe concreta que o implementa.

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

Nesse exemplo, a classe Dog implementa a interface IAnimal. Isso significa que um objeto da classe Dog pode ser tratado como uma instância de IAnimal, independentemente de sua classe concreta. A chamada do método Eat() do objeto myDog imprimirá "The dog is eating." ao invés de "The animal is eating.", que seria impresso se o objeto fosse tratado como uma instância da classe base Animal.

<hr>

# Upcasting e downcasting

Upcasting e downcasting são termos usados em programação orientada a objetos para descrever a conversão de tipos de objetos em C# (e outras linguagens de programação).
Upcasting ocorre quando um objeto é convertido em um tipo mais genérico (superclasse) na hierarquia de classes. Por exemplo, considere uma hierarquia de classes com as classes Animal, Cachorro e Gato. Se um objeto do tipo Cachorro for atribuído a uma variável do tipo Animal, ocorrerá um upcasting, já que a classe Animal é mais genérica do que a classe Cachorro.
Exemplo de upcasting em C#:

    Cachorro cachorro = new Cachorro();
    Animal animal = cachorro; // upcasting

Já o downcasting ocorre quando um objeto é convertido em um tipo mais específico (subclasse) na hierarquia de classes. Para realizar o downcasting, é necessário usar o operador de conversão explícita (tipo) ou o operador as em C#. Se a conversão não for válida, uma exceção do tipo InvalidCastException será lançada.
Exemplo de downcasting em C#:

    Animal animal = new Cachorro();
    Cachorro cachorro = (Cachorro)animal; // downcasting

É importante tomar cuidado com o downcasting, já que é possível perder informações do objeto original durante a conversão. Por exemplo, se o objeto original for da classe Gato e for convertido para a classe Cachorro através do downcasting, o programa pode falhar ou produzir resultados incorretos.
Em resumo, upcasting e downcasting são técnicas que permitem converter objetos entre classes na hierarquia de herança. Upcasting converte objetos em tipos mais genéricos, enquanto downcasting converte objetos em tipos mais específicos.
