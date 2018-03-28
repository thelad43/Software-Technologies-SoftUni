<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Celsius - Fahrenheit</title>
</head>

<body>
    <?php
            if (isset($_GET['cel'])) {
                $cel = $_GET['cel'];
                $fah = $cel * 9/5 + 32;
                $msgAfterCelsius = "$cel &deg;C = $fah &deg;F";
            } else if(isset($_GET['fah'])) {
                $fah = $_GET['fah'];
                $cel = ($fah - 32) * 5/9;
                $msgAfterCelsius = "$fah &deg;F = $cel &deg;C";
            }
        ?>

    <form>
        Celsius: <input type="text" name="cel" />
        <input type="submit" value="Convert">
        <?= $msgAfterCelsius ?>
    </form>
	
    <form>
        Fahrenheit: <input type="text" name="fah" />
        <input type="submit" value="Convert">
    </form>
</body>

</html>