<!DOCTYPE html>
<html lang="en">
<head>
    <style>
            div {
                display: inline-block;
                width: 150px;
                padding: 2px;
                margin: 5px;
            }
        </style>
    <meta charset="UTF-8">
    <title>Color Palette</title>
</head>

<body>
    <?php
            for ($r=0; $r <= 255; $r += 51) { 
                for ($g=0; $g <= 255; $g += 51) { 
                    for ($b=0; $b <= 255; $b += 51) { 
                        echo "<div style='background:rgb($r, $g, $b)'>rgb($r, $g, $b)</div>\n";
                    }        
                }
            }
        ?>
</body>

</html>