<?php
require 'vendor/autoload.php';
$cliente = new MongoDB\Client("mongodb://localhost:27017");
$ciudades = $cliente->mti->ciudades;

$resultado = $ciudades->insertOne( [ 'Nombre' => 'Tuluá'] );

echo "Documentos insertados: {$resultado->getInsertedCount()}. Id = '{$resultado->getInsertedId()}'";
echo "<hr/>";
echo "<pre>\n";
var_dump($resultado);
echo "\n</pre><hr/>";
var_dump($resultado->getInsertedId());
?>

