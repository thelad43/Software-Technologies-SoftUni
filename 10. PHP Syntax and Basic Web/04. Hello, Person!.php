<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Hello, Person!</title>
</head>

<body>
    <form>
        Name:
        <input type="text" name="person" />
        <input type="submit" />
    </form>
	
    <?php
     if (isset($_GET[ 'person'])) { 
         $person= htmlspecialchars($_GET[ 'person']);
          echo "Hello, $person!";
           } else { ?>
    <form>
	
        Name:
        <input type="text" name="person" />
        <input type="submit" />
    </form>
    <?php } ?>
</body>

</html>