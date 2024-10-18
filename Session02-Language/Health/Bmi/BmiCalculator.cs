namespace Bmi
{
    /// <summary>
    /// This class offers methods for evaluating the healthy status based on weight and height.
    /// </summary>
    public class BmiCalculator
    {
        /// <summary>
        /// Returns the BMI indicator of someone
        /// Hàm trả về chỉ số BMI của ai đó.
        /// </summary>
        /// <param name="w">Weight is under kg</param>
        /// <param name="h">Height is under m</param>
        /// <returns></returns>
        public static double GetBmi(double w, double h) => w / Math.Pow(h, 2);
    }
}
