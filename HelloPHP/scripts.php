<?php
$_numberOfPoints = 20000;
$radiusScale = 50;
$centreOffset = 1;

function rejectionSampling()
{
    while(TRUE){
        $x = random_0_1() * 2.0 - 1.0;
        $y = random_0_1() * 2.0 - 1.0;
        if($x*$x + $y*$y < 1.0)
            return array(
                ($x + $GLOBALS["centreOffset"]) * $GLOBALS["radiusScale"],
                ($y + $GLOBALS["centreOffset"]) * $GLOBALS["radiusScale"]);
    }
}

function randomPolar()
{
    $theta = random_0_1() * 2 * pi();
    $r = random_0_1();
    return array(
        ($r * cos($theta) + $GLOBALS["centreOffset"]) * $GLOBALS["radiusScale"], 
        ($r * sin($theta) + $GLOBALS["centreOffset"]) * $GLOBALS["radiusScale"]);
}

function sumDist()
{
    $theta = random_0_1() * 2 * pi();
    $r = random_0_1() + random_0_1();
    if($r >= 1)
        $r = 2 - $r;
    return array(
        ($r * cos($theta) + $GLOBALS["centreOffset"]) * $GLOBALS["radiusScale"], 
        ($r * sin($theta) + $GLOBALS["centreOffset"]) * $GLOBALS["radiusScale"]);
}

function maxDist()
{
    $theta = random_0_1() * 2 * pi();
    $r = random_0_1();
    $x = random_0_1();
    if($x > $r)
        $r = $x;
    return array(
        ($r * cos($theta) + $GLOBALS["centreOffset"]) * $GLOBALS["radiusScale"], 
        ($r * sin($theta) + $GLOBALS["centreOffset"]) * $GLOBALS["radiusScale"]);
}

function random_0_1() 
{
    return (float)rand() / (float)getrandmax();
}

?>