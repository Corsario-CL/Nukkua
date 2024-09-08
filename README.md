# Nukkua
#### Nukkua, es un programa para simular diferentes líquidos, Viscosidad y temperatura en diferentes ambientes. 

## Ecuación utilizada:
```
double factor = 1 - (0.02 * (temperatura - 25));
```
## Explicación:
#### Temperatura de referencia: La temperatura de referencia es 25°C, que es un valor común para medir la viscosidad de muchos líquidos. A esta temperatura, no se ajusta la viscosidad (es decir, el factor multiplicativo es 1).
#### Ajuste del factor por temperatura:
#### Por cada grado que la temperatura sube por encima de 25°C, la viscosidad disminuye un 2% (factor 0.02).
#### Por cada grado que la temperatura baja por debajo de 25°C, la viscosidad aumenta un 2%.
#### Factor multiplicativo: El resultado de este cálculo es un "factor" que se multiplica por la viscosidad base del líquido para obtener la viscosidad ajustada a la temperatura actual.

## Fórmula completa:
```
double CalcularViscosidadPorTemperatura(double viscosidadBase, int temperatura)
{
    double factor = 1 - (0.02 * (temperatura - 25)); // Baja un 2% por cada grado sobre 25°C
    return viscosidadBase * Math.Max(factor, 0.1); // Factor mínimo para evitar viscosidades negativas
}

```
#### El uso de Math.Max(factor, 0.1) asegura que el factor multiplicativo nunca sea inferior a 0.1, evitando que la viscosidad sea negativa o se reduzca demasiado, lo que podría causar resultados irreales.

# Interpretación física:
#### Esta es una aproximación simple. En la realidad, la viscosidad de muchos líquidos sigue una relación exponencial con la temperatura, y se puede modelar mejor usando ecuaciones más complejas.
#### como la ley de Arrhenius o con datos experimentales específicos para cada líquido.

# Pasos para ejecutar:
#### Crear un nuevo proyecto de Windows Forms App en Visual Studio.
#### Agregar el código proporcionado en los archivos Form1.cs y Form1.Designer.cs.
#### Ejecutar el proyecto y ver cómo se presenta la interfaz gráfica, seleccionas un líquido del ComboBox, y obtienes la viscosidad aproximada.

```
Lista de líquidos incluidos:
° Agua
° Aceite vegetal
° Glicerina
° Alcohol etílico
° Mercurio
° Miel
° Leche
° Gasolina
° Acetona
° Jabón líquido
° Jarabe de maíz
° Sangre
° Vinagre
° Aceite de motor
° Chocolate líquido
```
