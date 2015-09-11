# Шаблони за структуриране на обекти ( Structural Patterns)

Три извесни шаблона за структуриранe на обекти в обектно ориентираните езици за програмиране са:

 *   Composite Pattern
 *   Flyweight Pattern

## Composite Pattern

Шаблона Composite Pattern  ни позволява да създаваме йерархия от класове.
Той ни позволява да комбинираме различни обекти в една дървовидна структура.
Чрез този шаблон можем да третираме обектите по един и същ начин без значение
дали тези обекти са прости или композитни(които съдържат други обекти).
Това позволява на композитните обекти да съдържат други композитни обекти или други
прости обекти.

![](composite.gif)

Използва се когато искаме различни обекти които се наследяват едни други да ги третираме по един и същ начин.
> ### Получава се дървовидна структура.

### пример:


```sh
abstract class MailReceiver {
    public abstract void SendMail();
}


class EmailAddress : MailReceiver {
    public override void SendMail() { /*...*/ }
}

class GroupOfEmailAddresses : MailReceiver {
    private List<MailReceiver> participants;
    public override void SendMail() {
        foreach(var p in participants) p.SendMail();
    }
}
```
```sh
static void Main() {
    var rootGroup = new GroupOfEmailAddresses();
    rootGroup.SendMail();
}
```

## Flyweight Pattern

 Този шаблон се използва когато имаме много сходни обекти, като всеки обект заема
твърде много памет. Общите неща които съдържат тези обекти се изкарват в един Flyweight обект.
На този единствен обект в методите му подаваме като параметър разликите в различните обекти.
Така общата памет на всички обекти влиза като полета във Flyweight класа а различните данни
за всеки обект просто ги подаваме като параметри.Така се преизползва общата памет.

> Намаля количеството памет което ни е нужно.
> Пример от .NET е string.Intern()

![](flyweight.gif)
