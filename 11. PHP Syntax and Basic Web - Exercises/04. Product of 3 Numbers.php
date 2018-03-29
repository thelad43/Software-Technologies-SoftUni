<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
    <form>
        X: <input type="text" name="num1" />
		Y: <input type="text" name="num2" />
        Z: <input type="text" name="num3" />
		<input type="submit" />
    </form>

	<?php
        if(isset($_GET['num1']) && isset($_GET['num2']) && isset($_GET['num3'])) {
            $firstNum = intval($_GET['num1']);
            $secondNum = intval($_GET['num2']);
            $thirdNum = intval($_GET['num3']);

            $array = array($firstNum, $secondNum, $thirdNum);
            $countOfNegatives = 0;

            for ($i=0; $i < 3; $i++) {
                
                if($array[$i] == 0) {
                    echo "positive";
                    return;
                }
                
                if($array[$i] < 0) {
                    $countOfNegatives++;
                }
            }

            if ($countOfNegatives % 2 == 0) {
                echo "Positive";
            }
            else {
                echo "Negative";
            }
        }
    ?>
</body>
</html>