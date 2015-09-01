# Шаблони за създаване обекти  ( Creational Patterns)

Три извесни шаблона за създаване обекти в обектно ориентираните езици за програмиране са:

  - Singleton
  - Abstract Factory
  - Builder
  
# Singleton
Шаблона  Sngleton е позволява ние да имаме една единствена инстанция на даден обект в цялата ни програма или приложение. Никой друг да не може да създаде нова инстанция.Ние трябва да можем да се грижим за тази инстанция да е единствена и да я подаваме навсякъде където ни бъде поискана.
За да се случеи това този шаблон трябва да изпълнява две много важни изисквания:
 - Да осигурява единствена инстания на обекта
 - Да осигурява глобална точка за достъп

> Ако имаме някаква статична променлива която може да се достъпва навсякъде не означава че имаме
> реализация на шаблона Singleton.

### Възможни проблеми  
> Така наречения Lazy loading. Тоест можем да създадем тази единствена инстанция и никога да не я ползваме реално.
> Тази единствена инстанция да не е ThreadSafe. Тоест при многонишково програмиране две нишки да се опитат да създадат или получат достъп до тази инстанция по едно и също време.

### Недостатъци
- Получава се силна зависимост(coupling) от класа който предоставя инстанцията
- Нарушава се Single responsibility principle от SOLID принципите.

### Singleton на езика C#
- Еднонишкова реализация
```sh
public class Singleton {
    private static Singleton instance;
    protected Singleton() { }
	
    public static Singleton Instance() { 
        // Use 'Lazy initialization'
        if (instance == null) {
            instance = new Singleton();
        }
        return instance;
    }
}
```
- Многонишкова реализация чрез lock конструкция
```sh
public sealed class SingletonThreadSafe {
    private static volatile SingletonThreadSafe instance;
    private static object syncLock = new object();
    
    private SingletonThreadSafe() { }
    
    public static SingletonThreadSafe Instance {
        get {
            if (instance == null) {
                lock (syncLock) {
                    if (instance == null) {
                       instance = new SingletonThreadSafe();
                    }
                }
            } 
            return instance;
        }
    }
}
```
- Многонишкова реализация чрез вложен клас
```sh
public sealed class Singleton {
    private Singleton() { }
    public static Singleton Instance {
        get {
            return Nested.Instance;
        }
    }
      
    private class Nested {
        static Nested() { }
        internal static readonly Singleton Instance = new Singleton();
    }
}
```
- Многонишкова реализация чрез вградения в .NET клас Lazy
```sh
public sealed class Singleton
{
    private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>( () => new Singleton());
    
    public static Singleton Instance {
        get {
            return lazy.Value;
        }
    }
    private Singleton(){ }
}
```
- ##### See example Sinleton in Creational Patterns

# Abstract Factory

Шаблона Abstract Factory ни помага да създаваме обекти. В него се слага логиката при създаването на обекти.
Този шаблон консруира повече от един обект. Той ни дава interface за създаване на свързани по между си обекти.
Без да знаем конкретните класове.
```sh
abstract class ContinentFactory { // AbstractFactory
   public abstract Herbivore CreateHerbivore();
   public abstract Carnivore CreateCarnivore();
}
class AfricaFactory : ContinentFactory {
   public override Herbivore CreateHerbivore() {
      return new Wildebeest();
   }
   public override Carnivore CreateCarnivore() {
      return new Lion(); // Constructor can be internal
   }
}
class AmericaFactory : ContinentFactory {
    public override Herbivore CreateHerbivore() {
        return new Bison();
    }
    public override Carnivore CreateCarnivore() {
        return new Wolf();
    }
}
```

- ##### See example Abstract Factory in Creational Patterns
> Ние лесно можем да подменяме различните Factory класове или през клиентския код в Main метода
> или през App.config

```sh
var factoryClassName = ConfigurationManager.AppSettings["ManufacturerFactory"];
var foodFactory = Assembly.GetExecutingAssembly()
                            .CreateInstance(factoryClassName) as RestaurantFactory;

<configuration>
  <startup>
    <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.5" />
  </startup>
  <appSettings>
    <add key="ManufacturerFactory" value="Abstract_Factory.Factories.McDonaldsFactory"/>
  </appSettings>
</configuration>
```

# Bulder

Шаблона Builder се използва за конструиране на обекти. той се използва повече в ситуации при които
конструирането на обекти изисква някаква последователност от стъпки. Подредбата на стъпките по конструирането на обекта
се намира в така наречения Director клас. Director класа знае коя стъпка след коя следва, но не знае тази стъпка какво прави.
Всяка стъпка какво прави знае конкретния Builder (ConcreteBuilder) клас (в него е имплементацията). Director класа използва
този Builder. По този начин можем да комбинираме един Director с различни Builder класове или различни директори с различни
билдъри.

- ##### See example Builder in Creational Patterns