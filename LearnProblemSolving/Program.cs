using LearnProblemSolving;

TwoSumProblem ts = new TwoSumProblem();

var result = ts.TwoSum(new int[] { 2, 7, 11, 15 }, 18);

foreach (var item in result)
{
    Console.WriteLine(item);
}