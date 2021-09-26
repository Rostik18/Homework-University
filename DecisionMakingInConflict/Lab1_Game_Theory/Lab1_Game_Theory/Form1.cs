using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab1_Game_Theory
{
    public partial class Form1 : Form
    {
        private List<Vector> _firstPlayerStrategies = new List<Vector>();
        private List<Vector> _secondPlayerStrategies = new List<Vector>();

        private List<DefaultTask> defaultTasks = new List<DefaultTask>
        {
            new DefaultTask{ Label = "task 1", MatrixA = "1 1 2\n1 0 1\n5 1 2", MatrixB = "0 1 1\n5 5 4\n1 2 2" },
            new DefaultTask{ Label = "task 2", MatrixA = "3 3 3\n2 3 1\n3 2 4", MatrixB = "1 2 3\n2 3 3\n1 4 2" },
            new DefaultTask{ Label = "task 3", MatrixA = "2 1 3\n2 3 4\n1 4 4", MatrixB = "4 3 4\n5 3 3\n1 2 2" },
            new DefaultTask{ Label = "task 4", MatrixA = "1 1 3\n1 2 3\n3 2 3", MatrixB = "1 3 2\n3 2 1\n2 3 3" }
        };

        public Form1()
        {
            InitializeComponent();

            defaultTasksComboBox.DataSource = defaultTasks;

            ReadMatrices();
            UpdateViewMatrix();
        }

        private void calculateMatrixGameButton_Click(object sender, EventArgs e)
        {
            CleanLogs();
            ReadMatrices();
            UpdateViewMatrix();

            FindNotDominatedFor(_firstPlayerStrategies, 1);
            FindNotDominatedFor(_secondPlayerStrategies, 2);

            EquilibriumInDominant();

            ParetoOptimalSituation();

            CarefulStrategies(_firstPlayerStrategies, 1);
            CarefulStrategies(_secondPlayerStrategies, 2);

            IndividualRationalSituation();

            DiscussionSituations();

            logTextBox.ZoomFactor = 1.6f;
        }

        //ND
        private void FindNotDominatedFor(List<Vector> strategies, int i)
        {
            var notDominated = Vector.BestByPareto(strategies);

            logTextBox.Text += $"ND{i} = " + "{ " + $"{string.Join(", ", notDominated)}" + " } - недоміновані стратегії\n";
        }

        // D
        private void EquilibriumInDominant()
        {
            var notDominated1 = Vector.BestByPareto(_firstPlayerStrategies);
            var notDominated2 = Vector.BestByPareto(_secondPlayerStrategies);

            var notDominatedPositions1 = CalculatePositions(_firstPlayerStrategies, notDominated1);
            var notDominatedPositions2 = CalculatePositions(_secondPlayerStrategies, notDominated2);

            var equilibriums = new List<string>();
            var equilibriumPositions = new List<string>();

            foreach (var i in notDominatedPositions1)
            {
                foreach (var j in notDominatedPositions2)
                {
                    equilibriums.Add($"({_firstPlayerStrategies[i - 1][j - 1]} {_secondPlayerStrategies[j - 1][i - 1]})");
                    equilibriumPositions.Add($"({i} {j})");
                }
            }

            logTextBox.Text += "D = { " + $"{string.Join(", ", equilibriums)}" + " } позиції = { " +
                               $"{string.Join(", ", equilibriumPositions)}" + " } - рівновага в домінуючих стратегіях\n";
        }

        // PO
        private void ParetoOptimalSituation()
        {
            var paretoOptimal = CalculateParetoOptimal();

            logTextBox.Text += "PO = { " + $"{string.Join(", ", paretoOptimal)}" + " } - Парето оптимальні ситуації\n";
        }

        // O
        private void CarefulStrategies(List<Vector> strategies, int player)
        {
            var careful = CalculateCarefulStrategies(strategies);

            logTextBox.Text += $"O{player} = " + "{ " + $"{string.Join(", ", careful)}" + " } - обережні стратегії\n";
        }

        // IR
        private void IndividualRationalSituation()
        {
            var individualRational = CalculateIndividualRational(out var irPositions);

            logTextBox.Text += "IR = { " + $"{string.Join(", ", individualRational)}" + " } позиції = { " + $"{string.Join(", ", irPositions)}" + " } - індивідуально раціональні ситуації\n";
        }

        // П
        private void DiscussionSituations()
        {
            var ir = CalculateIndividualRational(out _);
            var po = CalculateParetoOptimal();

            var p = new List<Vector>();

            foreach (var v1 in ir)
            {
                foreach (var v2 in po)
                {
                    if (v1.CompareByValueWith(v2))
                    {
                        p.Add(v1);
                        break;
                    }
                }
            }

            logTextBox.Text += "П = { " + $"{string.Join(", ", p)}" + " } - переговорні ситуації\n";
        }

        private List<Vector> CalculateCarefulStrategies(List<Vector> strategies) =>
            strategies.Where(x => strategies.All(xx => x.Min() >= xx.Min())).ToList();

        private List<Vector> CalculateParetoOptimal()
        {
            var allSituations = new List<Vector>();

            for (var i = 0; i < _firstPlayerStrategies.Count; i++)
            {
                for (var j = 0; j < _secondPlayerStrategies.Count; j++)
                {
                    allSituations.Add(new Vector(_firstPlayerStrategies[i][j], _secondPlayerStrategies[j][i]));
                }
            }

            return Vector.BestByPareto(allSituations);
        }

        private List<Vector> CalculateIndividualRational(out List<string> positions)
        {
            var firstCareful = CalculateCarefulStrategies(_firstPlayerStrategies);
            var secondCareful = CalculateCarefulStrategies(_secondPlayerStrategies);

            if (!firstCareful.Any() || !secondCareful.Any())
            {
                positions = new List<string>();
                return new List<Vector>();
            }

            var firstRationalMin = firstCareful.First().Min();
            var secondRationalMin = secondCareful.First().Min();

            var individualRational = new List<Vector>();
            var irPositions = new List<string>();

            for (var i = 0; i < _firstPlayerStrategies.Count; i++)
            {
                for (var j = 0; j < _secondPlayerStrategies.Count; j++)
                {
                    if (_firstPlayerStrategies[i][j] >= firstRationalMin &&
                        _secondPlayerStrategies[j][i] >= secondRationalMin)
                    {
                        individualRational.Add(new Vector(_firstPlayerStrategies[i][j], _secondPlayerStrategies[j][i]));
                        irPositions.Add($"({i + 1} {j + 1})");
                    }
                }
            }

            positions = irPositions;
            return individualRational;
        }

        private List<int> CalculatePositions(List<Vector> strategies, List<Vector> notDominated)
        {
            var positions = new List<int>();
            for (var i = 0; i < strategies.Count; i++)
            {
                for (var j = 0; j < notDominated.Count; j++)
                {
                    if (strategies[i] == notDominated[j])
                    {
                        positions.Add(i + 1);
                        break;
                    }
                }
            }
            return positions;
        }

        private void ReadMatrices()
        {
            _firstPlayerStrategies = ReadMatrixA();
            _secondPlayerStrategies = ReadMatrixB();
        }

        private void CleanLogs() => logTextBox.Text = string.Empty;

        private void validateInputButton_Click(object sender, EventArgs e)
        {
            CleanLogs();

            ReadMatrices();

            var rowsCount = _firstPlayerStrategies.Count;
            var columnsCount = _secondPlayerStrategies.FirstOrDefault()?.Dimension ?? 0;

            if (rowsCount != columnsCount)
            {
                logTextBox.Text += "Неможливо скласти матричну гру\n";
                return;
            }

            UpdateViewMatrix();

            logTextBox.Text = "Дані валідні\n";
        }

        private void UpdateViewMatrix()
        {
            binarMatrixTextBox.Text = string.Empty;

            for (var i = 0; i < _firstPlayerStrategies.Count; i++)
            {
                for (var j = 0; j < _secondPlayerStrategies.Count; j++)
                {
                    binarMatrixTextBox.Text += $"({_firstPlayerStrategies[i][j]} {_secondPlayerStrategies[j][i]})\t";
                }

                binarMatrixTextBox.Text += "\n";
            }

            binarMatrixTextBox.ZoomFactor = 1.8f;
        }

        private List<Vector> ReadMatrixA()
        {
            try
            {
                var rows = matrixATextBox.Text.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                var playerStrategies = new List<Vector>(rows.Length);

                foreach (var row in rows)
                {
                    var numbers = row.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

                    playerStrategies.Add(new Vector(numbers));
                }

                var dimension = playerStrategies.FirstOrDefault()?.Dimension ?? 0;

                if (playerStrategies.Any(x => x.Dimension != dimension))
                {
                    logTextBox.Text += "Матриця першого гравця не прямокутна\n";
                }

                return playerStrategies;
            }
            catch
            {
                logTextBox.Text += "Помилка читання матриці першого гравця\n";
                return new List<Vector>();
            }
        }

        private List<Vector> ReadMatrixB()
        {
            try
            {
                var rows = matrixBTextBox.Text.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                var vectors = new List<Vector>(rows.Length);

                foreach (var row in rows)
                {
                    var numbers = row.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                    vectors.Add(new Vector(numbers));
                }

                var dimension = vectors.FirstOrDefault()?.Dimension ?? 0;

                if (vectors.Any(x => x.Dimension != dimension))
                {
                    logTextBox.Text += "Матриця другого гравця не прямокутна\n";
                    return new List<Vector>();
                }

                var matrix = new Matrix(vectors.ToArray());

                return matrix.Transpose().ToVectors();
            }
            catch
            {
                logTextBox.Text += "Помилка читання матриці другого гравця\n";
                return new List<Vector>();
            }
        }

        private void defaultTasksComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTask = defaultTasks[defaultTasksComboBox.SelectedIndex];

            matrixATextBox.Text = selectedTask.MatrixA;
            matrixBTextBox.Text = selectedTask.MatrixB;

            CleanLogs();
            ReadMatrices();
            UpdateViewMatrix();

            matrixATextBox.ZoomFactor = 2;
            matrixBTextBox.ZoomFactor = 2;
        }
    }
}
