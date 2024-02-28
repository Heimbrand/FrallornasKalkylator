using DataAccess;

namespace Common;

public class CalcService(CalcHistoryService calculationHistoryService)
{
    public CalcHistoryService CalcHistoryService { get; set; } = calculationHistoryService;

    public decimal Calculate(decimal numberOne, decimal numberTwo, string operation)
    {
        var result = operation switch
        {
            "+" => numberOne + numberTwo,
            "-" => numberOne - numberTwo,
            "*" => numberOne * numberTwo,
            "/" => numberTwo == 0 ? 0 : numberOne / numberTwo,
            _ => 0
        };

        var calculationModel = new CalculationModel
        {
            NumberOne = numberOne,
            NumberTwo = numberTwo,
            Operator = operation,
            CalculationTime = DateTime.Now,
            Result = result
        };
        calculationHistoryService.CalculationList.Add(calculationModel);

        return result;
    }
}