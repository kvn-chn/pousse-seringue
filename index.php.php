<html>
    <head>
        <link rel="stylesheet" href="style.css">
        <meta http-equiv="refresh" content="10">
    </head>

    <body>
        <h1 class = "centerMargin"> Tableau des traitements </h1></br>
    <table>
        <tr>
            <th>Patient</th>
            <th>Infirmier</th>
            <th>Débit volumique</th>
            <th>Volume injection</th>
            <th>Début traitement</th>
            <th>Type seringue</th>
            <th>Volume injecté</th>
            <th>Volume restant</th>
            <th>Temps restant</th>
        </tr>
        <?php 
        $servername = "localhost";
        $username = "root";
        $password = "";
        $dbname = "dbpousseseringue";

        echo $_SERVER['REQUEST_TIME'];

        // Create connection
        $conn = new mysqli($servername, $username, $password, $dbname);
        // Check connection
        if ($conn->connect_error) {
        die("Connection failed: " . $conn->connect_error);
        }

        $sql = "SELECT Patient_NumSecu, Infirmier_idInfirmier ,DebitVolumique, VolumeInjection, DebutTraitement, TypeSeringue, VolumeInjecte, VolumeRestant, TempsRestant FROM traitementseringue";
        $result = $conn->query($sql);
        
        if ($result != null) 
        {
            // output data of each row
            while($row = $result->fetch_assoc()) 
            {
              ?>
                <tr>
                    <td><?php echo $row["Patient_NumSecu"];?></td>
                    <td><?php echo $row["Infirmier_idInfirmier"];?></td>
                    <td><?php echo $row["DebitVolumique"];?> ml/h</td>
                    <td><?php echo $row["VolumeInjection"];?> ml</td>
                    <td><?php echo $row["DebutTraitement"];?></td>
                    <td><?php echo $row["TypeSeringue"];?></td>
                    <td><?php echo $row["VolumeInjecte"];?> ml</td>
                    <td><?php echo $row["VolumeRestant"];?> ml</td>
                    <td><?php echo $row["TempsRestant"];?></td>                   
                </tr>
                <?php
            }
        }
        else 
        {
            echo "0 results";
        }
        $conn->close();
        ?>
        </table>
    </body>
</html>