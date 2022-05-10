using AppliedMathLibrary.Methods;
using HeteroskedasticityChecking;

var manpowerMeanBef = Statistics.Mean(Data.BeforeRetreating.Manpower);
var tanksMeanBef = Statistics.Mean(Data.BeforeRetreating.Tanks);
var ifvMeanBef = Statistics.Mean(Data.BeforeRetreating.Ifv);

var manpowerMeanAft = Statistics.Mean(Data.AfterRetreating.Manpower);
var tanksMeanAft = Statistics.Mean(Data.AfterRetreating.Tanks);
var ifvMeanAft = Statistics.Mean(Data.AfterRetreating.Ifv);


var manpowerVarBef = Statistics.Var(Data.BeforeRetreating.Manpower);
var tanksVarBef = Statistics.Var(Data.BeforeRetreating.Tanks);
var ifvVarBef = Statistics.Var(Data.BeforeRetreating.Ifv);

var manpowerVarAft = Statistics.Var(Data.AfterRetreating.Manpower);
var tanksVarAft = Statistics.Var(Data.AfterRetreating.Tanks);
var ifvVarAft = Statistics.Var(Data.AfterRetreating.Ifv);

Console.WriteLine($"Порiвняння статистики зниження ворога в перiод до вiдступу ворога з пiвночi України (17.03.2022 - 30.03.2022)");
Console.WriteLine($"та 2 тижнi з початку другої фази наступу ворога на сходi України (22.04.2022 - 05.05.2022)");
Console.WriteLine($"       |mean bef\t|mean aft\t|var bef\t|var aft");
Console.WriteLine($"manpow |{manpowerMeanBef:f1}\t\t|{manpowerMeanAft:f1}\t\t|{manpowerVarBef:f1}\t\t|{manpowerVarAft:f1}\t");
Console.WriteLine($"tanks  |{tanksMeanBef:f1}\t\t|{tanksMeanAft:f1}\t\t|{tanksVarBef:f1}\t\t|{tanksVarAft:f1}\t");
Console.WriteLine($"ifv    |{ifvMeanBef:f1}\t\t|{ifvMeanAft:f1}\t\t|{ifvVarBef:f1}\t\t|{ifvVarAft:f1}\t");

var alfa = 0.05;

var manpowerW = LeveneTest.Run(Data.BeforeRetreating.Manpower, Data.AfterRetreating.Manpower);
var tanksW = LeveneTest.Run(Data.BeforeRetreating.Tanks, Data.AfterRetreating.Tanks);
var ifvW = LeveneTest.Run(Data.BeforeRetreating.Ifv, Data.AfterRetreating.Ifv);

var accept = "Рiзниця дисперсiй статистично незначуща. H0 - приймається";
var reject = "Рiзницю дисперсiй статистично значуща. H0 - хибна гiпотеза, дисперсiї є рiзними";

var a = manpowerW < alfa ? reject : accept;
var b = tanksW < alfa ? reject : accept;
var c = ifvW < alfa ? reject : accept;

Console.WriteLine($"рiвень значущостi alfa = {alfa}");
Console.WriteLine($"       |знач стат W\t|виконання умови W < {alfa}");
Console.WriteLine($"manpow |{manpowerW:f4}\t\t|{a}");
Console.WriteLine($"tanks  |{tanksW:f4}\t\t|{b}");
Console.WriteLine($"ifv    |{ifvW:f4}\t\t|{c}");
