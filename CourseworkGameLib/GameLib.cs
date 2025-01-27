namespace CourseworkGameLib
{
    public class Character 
    {
        protected string name;
        public string Name { get { return name; } set { name = value; } }
        public List<string> Coctails;
        public List<string> Recipies;
        protected List<string> storyLines;
        protected int coctailNum;
        public int CoctailNum { get { return coctailNum; } set { coctailNum = value; } }
        public Character()
        {
            Name = "-";
            Coctails = new List<string>();
            Recipies = new List<string>();
            storyLines = new List<string>();
            CoctailNum = 0;
        }
        public virtual void StoryLines(int line) { }
    }

    public class Lilith : Character
    {
        public override void StoryLines(int line)
        {
            
        }
        int coctailGiftNum;
        public int CoctailGiftNum { get { return coctailGiftNum; }  set { coctailGiftNum = value; } }
        public Lilith() 
        { 
            Name = "Lilith";
            CoctailGiftNum = 0;
            CoctailGiftNum = 1;
            Coctails = new List<string> { "Алая роза", "Белая дымка" };
            Recipies = new List<string> { "", "" };
            /*
             * диалоги:
             * 1. приветствие
             * 2./3. ответы (2) на приветствие
             * 4. заказ коктейля (описание 1)
             * 5. уточнение деталей (описание 2) \\ уже не особо довольна игроком
             * 6. уточнение деталей 2 (описание 3) \\ расстроена, не подарит рецепт нового коктейля
             * 7. принятие заказа, если он верный
             * 8. отказ и уход, если неверный
             * 9./10. если коктейль угадан без уточнений, то рассказывает немного об этом мире
             * 11. отдает рецепт коктейля, если угадан он без уточнений
             * 12. дает подсказку для следующего клиента, если было 1 уточнение
             * 13. забирает заказ и уходит, если были уточнения
             */
            storyLines = new List<string>
            {

            };
        }
    }

    public class Peter : Character
    {

    }
}
