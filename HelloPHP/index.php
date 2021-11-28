<!DOCTYPE html>
<html>

<head>
    <title>Hello php</title>
    <meta charset="utf-8">
    <style>
        .circle {
            position: relative;
            width: 100px;
            height: 100px;
            -webkit-border-radius: 50px;
            -moz-border-radius: 50px;
            border-radius: 50px;
            background: rgb(121, 121, 121);
        }

        .point {
            position: absolute; 
            width: 2px;
            height: 2px;
            -webkit-border-radius: 1px;
            -moz-border-radius: 1px;
            background: green;
        }
    </style>
</head>

<body>
    <?php
        include 'scripts.php';
        echo "<h6>Кількість точок: $_numberOfPoints </h6>";        
    ?>
    <table>
        <tr>
            <td>
                <div>
                    <h6>Звичайний метод (рандомити x та y доки не виконається нерівність кола):   </h6>
                    <div class="circle">
                        <?php
                            $start = round(microtime(true) * 1000);
                            for ($i = 0; $i < $_numberOfPoints; $i++)
                            {
                                list($x, $y) = rejectionSampling();
                                $x = (int)$x;
                                $y = (int)$y;

                                echo "<div class='point' style='left:{$x}px; bottom:{$y}px;' ></div>";
                            }
                            $end = round(microtime(true) * 1000);
                            $diff = $end - $start;
                        ?>
                    </div>
                    <?php echo "<small>Це зайняло часу: {$diff} ms</small>"; ?>
                </div>
            </td>
            <td>
                <div>
                    <h6>В полярній системі (точки купчаться в центрі):</h6>
                    <div class="circle">
                        <?php
                            $start = round(microtime(true) * 1000);
                            for ($i = 0; $i < $_numberOfPoints; $i++)
                            {
                                list($x, $y) = randomPolar();
                                $x = (int)$x;
                                $y = (int)$y;

                                echo "<div class='point' style='left:{$x}px; bottom:{$y}px;' ></div>";
                            }
                            $end = round(microtime(true) * 1000);
                            $diff = $end - $start;
                        ?>
                    </div>
                    <?php echo "<small>Це зайняло часу: {$diff} ms</small>"; ?>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <div>
                    <h6>Полярна система без дефекту:</h6>
                    <div class="circle">
                        <?php
                            $start = round(microtime(true) * 1000);
                            for ($i = 0; $i < $_numberOfPoints; $i++)
                            {
                                list($x, $y) = sumDist();
                                $x = (int)$x;
                                $y = (int)$y;

                                echo "<div class='point' style='left:{$x}px; bottom:{$y}px;' ></div>";
                            }
                            $end = round(microtime(true) * 1000);
                            $diff = $end - $start;
                        ?>
                    </div>
                    <?php echo "<small>Це зайняло часу: {$diff} ms</small>"; ?>
                </div>
            </td>
            <td>
                <div>
                    <h6>Метод відображення суми:</h6>
                    <div class="circle">
                        <?php
                            $start = round(microtime(true) * 1000);
                            for ($i = 0; $i < $_numberOfPoints; $i++)
                            {
                                list($x, $y) = maxDist();
                                $x = (int)$x;
                                $y = (int)$y;

                                echo "<div class='point' style='left:{$x}px; bottom:{$y}px;' ></div>";
                            }
                            $end = round(microtime(true) * 1000);
                            $diff = $end - $start;
                        ?>
                    </div>
                    <?php echo "<small>Це зайняло часу: {$diff} ms</small>"; ?>
                </div>
            </td>
        </tr>
    </table>
</body>

</html>