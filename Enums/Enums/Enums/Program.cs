using Enums._01_Basic_example;

namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region basic

            //Season autumn = Season.Autumn;
            //Console.WriteLine();
            //Console.WriteLine((int)autumn);

            //UshortEnum ushortEnum = UshortEnum.ConnectionLost;
            //Console.WriteLine(ushortEnum);

            #endregion

            #region Convertion

            //int enumNumber = Season.Autumn; //Error
            ////int enumNumber = (int)Season.Autumn;
            //Console.WriteLine(enumNumber);

            //Season season = 1; //Error
            ////Season season = (Season)1;
            //Console.WriteLine(season);

            //Season season = (Season)10;
            //Console.WriteLine(season); //not Ok; 10

            /* compile-time error */
            //UshortEnum ushortEnum = (UshortEnum)-1;

            /* convert non-existing value */
            //int num = ushort.MaxValue + 1;  //65536
            //UshortEnum ushortEnum = (UshortEnum)num;
            //Console.WriteLine(ushortEnum); //Not ok! "None"

            /* Check if the value is defined */
            //Season season = (Season)10;
            //if (Enum.IsDefined(typeof(Season), season))
            //{
            //    Console.WriteLine(season);
            //}
            //else
            //{
            //    Console.WriteLine($"season #{season} doesn't exist");
            //}

            #endregion

            #region default value

            ///* The default value of an enumeration type E is the value produced by expression (E)0, even if zero doesn't have the corresponding enum member. */
            //Season newSeason = new Season();
            //Console.WriteLine(newSeason); //Ok! "None"

            //WithoutZeroValueEnum enumValue = default(WithoutZeroValueEnum);
            //Console.WriteLine(enumValue); //Not Ok!  0

            #endregion

            #region exception with assigning non-existing value

            /* Exception because of the value greater than the max value for the underlying type */
            //ConsoleColor color = (ConsoleColor)16; //Ok
            //Console.BackgroundColor = color; //System.ArgumentException

            #endregion



            Console.ReadLine();
        }
    }
}