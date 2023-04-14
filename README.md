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

<hr>

# Sobreposição, palavras virtual, override e base

Em C#, a sobreposição de métodos é um recurso que permite que uma classe filha (subclasse) substitua a implementação de um método da classe pai (superclasse). Isso permite que a classe filha modifique ou estenda o comportamento de um método herdado.
Para permitir que uma classe filha substitua um método da classe pai, o método deve ser declarado com o modificador virtual na classe pai e substituído com o modificador override na classe filha. A classe filha também pode chamar a implementação original do método na classe pai usando a palavra-chave base.
Veja um exemplo de como usar a sobreposição, a palavra virtual, override e base em C#:

    public class Animal {
        public virtual void EmitirSom() {
            Console.WriteLine("Animal emitindo som...");
        }
    }

    public class Cachorro : Animal {
        public override void EmitirSom() {
            Console.WriteLine("Cachorro latindo...");
            base.EmitirSom(); // chamando a implementação original na classe pai
        }
    }

    //...

    Animal animal = new Cachorro();
    animal.EmitirSom(); // imprime "Cachorro latindo..." e "Animal emitindo som..."

Nesse exemplo, a classe Animal declara um método EmitirSom() como virtual, permitindo que classes filhas possam substituí-lo. A classe Cachorro substitui o método EmitirSom() da classe Animal com o modificador override, adicionando uma nova funcionalidade de latido e chamando a implementação original do método da classe pai usando a palavra-chave base.
Quando o método EmitirSom() é chamado no objeto Cachorro usando uma variável do tipo Animal, a implementação substituída na classe Cachorro é chamada, seguida pela implementação original na classe Animal, graças à chamada base.EmitirSom().
Em resumo, a sobreposição de métodos permite que uma classe filha substitua a implementação de um método da classe pai. Para fazer isso, o método deve ser declarado com o modificador virtual na classe pai e substituído com o modificador override na classe filha. A classe filha também pode chamar a implementação original do método na classe pai usando a palavra-chave base.

## Classe ou método selado (ou sealed)

Em C#, uma classe ou método selado (ou sealed) é uma classe ou método que não pode ser herdado ou sobreposto por classes filhas.
Uma classe selada é definida usando o modificador sealed na declaração da classe. Isso indica que a classe não pode ser usada como uma classe pai (superclasse) para outras classes. Qualquer tentativa de herdar de uma classe selada resultará em um erro de compilação.
Por exemplo:

    public sealed class ClasseSelada {
        // ...
    }

    // Erro de compilação: não é possível herdar de uma classe selada
    public class ClasseFilha : ClasseSelada {
        // ...
    }

Da mesma forma, um método selado é definido usando o modificador sealed na declaração do método. Isso indica que o método não pode ser sobreposto por métodos em classes filhas (subclasses).
Por exemplo:

    public class Animal {
        public sealed void EmitirSom() {
            Console.WriteLine("Animal emitindo som...");
        }
    }

    public class Cachorro : Animal {
        // Erro de compilação: não é possível sobrepor um método selado
        public override void EmitirSom() {
            Console.WriteLine("Cachorro latindo...");
        }
    }

Nesse exemplo, a classe Animal declara um método EmitirSom() como selado, impedindo que as classes filhas possam substituí-lo. A classe Cachorro tenta substituir o método EmitirSom() da classe Animal, mas isso resulta em um erro de compilação devido ao método ser selado.
O uso de classes e métodos selados pode ajudar a garantir que certos aspectos críticos do comportamento do programa não sejam modificados inadvertidamente por classes filhas. No entanto, é importante usá-los com cuidado, pois a sobreposição de métodos é uma ferramenta poderosa para a extensibilidade e flexibilidade de um programa orientado a objetos.

<hr>

# Polimorfismo 

O polimorfismo é um dos conceitos fundamentais da programação orientada a objetos e permite que objetos de diferentes classes possam ser tratados de maneira uniforme. Em C#, o polimorfismo é alcançado por meio da sobreposição de métodos e da utilização de referências de tipos base para objetos de tipos derivados.
A sobreposição de métodos permite que um método em uma classe derivada (subclasse) substitua a implementação de um método correspondente na classe base (superclasse). Por exemplo:

    public class Animal {
        public virtual void EmitirSom() {
            Console.WriteLine("Animal emitindo som...");
        }
    }

    public class Cachorro : Animal {
        public override void EmitirSom() {
            Console.WriteLine("Cachorro latindo...");
        }
    }

    public class Gato : Animal {
        public override void EmitirSom() {
            Console.WriteLine("Gato miando...");
        }
    }

Neste exemplo, as classes Cachorro e Gato substituem o método EmitirSom() da classe Animal para adicionar seu próprio comportamento.
Agora, vamos criar uma instância de cada classe e chamá-las pelo método EmitirSom():

    Animal animal1 = new Animal();
    Animal animal2 = new Cachorro();
    Animal animal3 = new Gato();

    animal1.EmitirSom(); // imprime "Animal emitindo som..."
    animal2.EmitirSom(); // imprime "Cachorro latindo..."
    animal3.EmitirSom(); // imprime "Gato miando..."

Aqui, cada objeto é tratado como um tipo Animal, que é a classe base comum entre Animal, Cachorro e Gato. O método EmitirSom() é chamado para cada objeto, mas o comportamento é diferente em cada caso, graças à sobreposição de métodos. Este é um exemplo de polimorfismo em ação.
Em resumo, o polimorfismo em C# é alcançado por meio da sobreposição de métodos e do uso de referências de tipos base para objetos de tipos derivados. O polimorfismo permite que objetos de diferentes classes sejam tratados de maneira uniforme, o que pode tornar o código mais flexível e extensível.

<hr>

# Metodos e Classes Abstrattas

Uma classe abstrata é uma classe que não pode ser instanciada, mas que serve como um modelo ou base para outras classes. Em outras palavras, uma classe abstrata é uma classe que não pode ser usada diretamente, mas deve ser estendida por outras classes para que seus métodos e propriedades possam ser usados.
Em C#, uma classe abstrata é definida usando a palavra-chave abstract. Qualquer classe que contém pelo menos um método abstrato deve ser declarada como abstrata. Um método abstrato é um método que é declarado, mas não contém uma implementação.
Por exemplo:

    public abstract class Animal {
        public abstract void EmitirSom();
    }

    public class Cachorro : Animal {
        public override void EmitirSom() {
            Console.WriteLine("Cachorro latindo...");
        }
    }

    public class Gato : Animal {
        public override void EmitirSom() {
            Console.WriteLine("Gato miando...");
        }
    }

Neste exemplo, a classe Animal é declarada como abstrata e contém um método abstrato EmitirSom(). As classes Cachorro e Gato herdam da classe Animal e implementam o método abstrato.
É importante notar que uma classe abstrata pode conter métodos não abstratos com implementações concretas. No entanto, uma classe que contém pelo menos um método abstrato deve ser declarada como abstrata e não pode ser instanciada diretamente.
As classes abstratas são úteis quando se deseja criar uma classe base que defina um conjunto de métodos e propriedades que outras classes derivadas possam implementar de maneiras diferentes. As classes abstratas fornecem uma maneira de compartilhar comportamento comum entre várias classes relacionadas, enquanto permitem que cada classe filha forneça sua própria implementação personalizada.
Em resumo, uma classe abstrata é uma classe que não pode ser instanciada, mas serve como um modelo ou base para outras classes. Em C#, uma classe abstrata é definida usando a palavra-chave abstract e pode conter métodos abstratos, que são métodos declarados, mas não contêm uma implementação. As classes abstratas são úteis quando se deseja criar uma classe base que defina um conjunto de métodos e propriedades que outras classes derivadas possam implementar de maneiras diferentes.
