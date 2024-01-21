using BarajaSpain.Desktop.Entities; 

namespace BarajaSpain.Desktop.Core
{
    public class Esqueleto: IEsqueleto
    {
        private List<Hueso>? Huesos { get; set; } = null;
        public Esqueleto() {
            Cargar();
        }
        public void Cargar()
        {
            Huesos = new List<Hueso>() {
                new Hueso(){Nombre="Craneo Frontal.",Peso=59.61,Densidad=14.28,Longitud=11.27,Diametro=4.40},
                new Hueso(){Nombre="Craneo Occipital.",Peso=68.79,Densidad=1.99,Longitud=18.59,Diametro=4.07},
                new Hueso(){Nombre="Craneo Parietal izquierdo.",Peso=46.49,Densidad=10.45,Longitud=5.15,Diametro=2.32},
                new Hueso(){Nombre="Craneo Parietal derecho.",Peso=37.4,Densidad=10.75,Longitud=6.54,Diametro=4.32},
                new Hueso(){Nombre="Craneo Temporal izquierdo.",Peso=10.38,Densidad=12.85,Longitud=11.08,Diametro=4.22},
                new Hueso(){Nombre="Craneo Temporal derecho.",Peso=37.16,Densidad=9.6,Longitud=15.05,Diametro=2.54},
                new Hueso(){Nombre="Craneo Esfenoides.",Peso=10.16,Densidad=15.05,Longitud=5.46,Diametro=2.54},
                new Hueso(){Nombre="Craneo Etmoides.",Peso=15.81,Densidad=18.19,Longitud=5.54,Diametro=3.93},
                new Hueso(){Nombre="Craneo Maxilar inferior o mandíbula.",Peso=62.56,Densidad=9.19,Longitud=16.81,Diametro=2.04},
                new Hueso(){Nombre="Craneo Maxilar superior izquierdo.",Peso=52.31,Densidad=8.99,Longitud=18.98,Diametro=3.45},
                new Hueso(){Nombre="Craneo Maxilar superior derecho.",Peso=12.52,Densidad=1.66,Longitud=9.38,Diametro=3.89},
                new Hueso(){Nombre="Craneo Palatino izquierdo.",Peso=17.11,Densidad=15.67,Longitud=16.66,Diametro=4.19},
                new Hueso(){Nombre="Craneo Palatino derecho.",Peso=38,Densidad=18.2,Longitud=19.43,Diametro=2.11},
                new Hueso(){Nombre="Craneo Malar o cigomático izquierdo.",Peso=49.33,Densidad=6.52,Longitud=19.62,Diametro=1.06},
                new Hueso(){Nombre="Craneo Malar o cigomático derecho.",Peso=40,Densidad=18.09,Longitud=10.68,Diametro=4.87},
                new Hueso(){Nombre="Craneo Nasal izquierdo.",Peso=28.78,Densidad=15.04,Longitud=19.67,Diametro=3.04},
                new Hueso(){Nombre="Craneo Nasal derecho.",Peso=35.4,Densidad=6.96,Longitud=16.89,Diametro=3.93},
                new Hueso(){Nombre="Craneo Unguis o lagrimal izquierdo.",Peso=31.16,Densidad=3.06,Longitud=6.87,Diametro=4.37},
                new Hueso(){Nombre="Craneo Unguis o lagrimal derecho.",Peso=10.74,Densidad=1.55,Longitud=14.27,Diametro=3.11},
                new Hueso(){Nombre="Craneo Vómer.",Peso=21.03,Densidad=8.09,Longitud=9.42,Diametro=3.04},
                new Hueso(){Nombre="Craneo Cornete nasal izquierdo.",Peso=64,Densidad=18.08,Longitud=16.71,Diametro=2.58},
                new Hueso(){Nombre="Craneo Cornete nasal derecho.",Peso=36.23,Densidad=10.29,Longitud=9.31,Diametro=1.60},
                new Hueso(){Nombre="Craneo Martillo izquierdo.",Peso=66.17,Densidad=4.62,Longitud=15.24,Diametro=2.73},
                new Hueso(){Nombre="Craneo Martillo derecho.",Peso=64.8,Densidad=11.08,Longitud=19.83,Diametro=4.33},
                new Hueso(){Nombre="Craneo Yunque izquierdo.",Peso=24.6,Densidad=12.92,Longitud=6.54,Diametro=1.18},
                new Hueso(){Nombre="Craneo Yunque derecho.",Peso=39.49,Densidad=1.21,Longitud=18.5,Diametro=3.56},
                new Hueso(){Nombre="Craneo Estribo izquierdo.",Peso=12.69,Densidad=9.61,Longitud=6.1,Diametro=1.18},
                new Hueso(){Nombre="Craneo Estribo derecho.",Peso=48.4,Densidad=15.52,Longitud=14.82,Diametro=3.67},
                new Hueso(){Nombre="Craneo Hioides. ",Peso=11.11,Densidad=7.96,Longitud=5.89,Diametro=3.49},
                new Hueso(){Nombre="Vértebra cervical C1. Llamada Atlas.",Peso=40.04,Densidad=4.01,Longitud=10.36,Diametro=3.27},
                new Hueso(){Nombre="Vértebra cervical C2. Llamada Axis.",Peso=14.97,Densidad=4.32,Longitud=5.91,Diametro=2.35},
                new Hueso(){Nombre="Vértebra cervical C3. Llamada C3.",Peso=48.01,Densidad=2.82,Longitud=15.4,Diametro=4.62},
                new Hueso(){Nombre="Vétrebra cervical C4. Llamada C4.",Peso=29.82,Densidad=17.49,Longitud=14.32,Diametro=2.26},
                new Hueso(){Nombre="Vértebra cervical C5. Llamada C5.",Peso=47.53,Densidad=8.16,Longitud=18.48,Diametro=1.11},
                new Hueso(){Nombre="Vértebra cervical C6. Llamada C6.",Peso=52.83,Densidad=18.73,Longitud=5.48,Diametro=2.31},
                new Hueso(){Nombre="Vertebra cervical C7. Llamada Prominente.",Peso=33.82,Densidad=19.93,Longitud=15.8,Diametro=3.21},
                new Hueso(){Nombre="Vértebra dorsal o torácica T1. Llamada T1",Peso=61.07,Densidad=8.13,Longitud=10.58,Diametro=2.79},
                new Hueso(){Nombre="Vértebra dorsal o torácica T2. Llamada T2",Peso=60.44,Densidad=11.52,Longitud=11.56,Diametro=3.22},
                new Hueso(){Nombre="Vértebra dorsal o torácica T3. Llamada T3",Peso=47.42,Densidad=1.28,Longitud=7.13,Diametro=3.87},
                new Hueso(){Nombre="Vértebra dorsal o torácica T4. Llamada T4",Peso=46.96,Densidad=11.88,Longitud=12.78,Diametro=3.24},
                new Hueso(){Nombre="Vértebra dorsal o torácica T5. Llamada T5",Peso=53.93,Densidad=5.47,Longitud=17.98,Diametro=2.59},
                new Hueso(){Nombre="Vértebra dorsal o torácica T6. Llamada T6",Peso=58.9,Densidad=13.78,Longitud=11.02,Diametro=2.79},
                new Hueso(){Nombre="Vértebra dorsal o torácica T7. Llamada T7",Peso=11.02,Densidad=12.68,Longitud=9.09,Diametro=3.04},
                new Hueso(){Nombre="Vértebra dorsal o torácica T8. Llamada T8",Peso=12.57,Densidad=5.83,Longitud=7.54,Diametro=3.93},
                new Hueso(){Nombre="Vértebra dorsal o torácica T9. Llamada T9",Peso=40.8,Densidad=7.24,Longitud=18.14,Diametro=2.36},
                new Hueso(){Nombre="Vértebra dorsal o torácica T10. Llamada T10.",Peso=53.99,Densidad=15.43,Longitud=6.58,Diametro=4.00},
                new Hueso(){Nombre="Vértebra dorsal o torácica T11. Llamada T11.",Peso=22.45,Densidad=1.79,Longitud=14.25,Diametro=2.88},
                new Hueso(){Nombre="Vértebra dorsal o torácica T12. Llamada T12.",Peso=51.84,Densidad=11.07,Longitud=9.23,Diametro=1.48},
                new Hueso(){Nombre="Vértebra Lumbar L1. Llamada L1.",Peso=62.09,Densidad=11.59,Longitud=18.53,Diametro=3.75},
                new Hueso(){Nombre="Vértebra Lumbar L2. Llamada L2.",Peso=26.23,Densidad=1.89,Longitud=14.92,Diametro=1.13},
                new Hueso(){Nombre="Vértebra Lumbar L3. Llamada L3.",Peso=64.41,Densidad=12.15,Longitud=7.68,Diametro=3.83},
                new Hueso(){Nombre="Vértebra Lumbar L4. Llamada L4.",Peso=31.63,Densidad=4.76,Longitud=17.46,Diametro=3.43},
                new Hueso(){Nombre="Vértebra Lumbar L5. Llamada L5.",Peso=31.07,Densidad=5.89,Longitud=8.94,Diametro=4.84},
                new Hueso(){Nombre="Sacro formado por 5 vértebras soldadas.",Peso=33.88,Densidad=6.23,Longitud=8.61,Diametro=2.78},
                new Hueso(){Nombre="Coxis formado po5 4 ó 5 vértebaras fusionadas. ",Peso=51.13,Densidad=19.74,Longitud=9.5,Diametro=3.14},
                new Hueso(){Nombre="Esternon.",Peso=64.61,Densidad=6.46,Longitud=5.56,Diametro=2.28},
                new Hueso(){Nombre="Costilla verdedera izquierda unida a la vértebra T1 y esternón.",Peso=63.55,Densidad=19.61,Longitud=19.29,Diametro=3.02},
                new Hueso(){Nombre="Costilla verdedera derecha unida a la vértebra T1 y esternón.",Peso=61.89,Densidad=19.71,Longitud=16.52,Diametro=4.48},
                new Hueso(){Nombre="Costilla verdedera izquierda unida a la vértebra T2 y esternón.",Peso=50.65,Densidad=14.83,Longitud=9.86,Diametro=2.92},
                new Hueso(){Nombre="Costilla verdedera derecha unida a la vértebra T2 y esternón.",Peso=32.7,Densidad=8.07,Longitud=13.42,Diametro=4.93},
                new Hueso(){Nombre="Costilla verdedera izquierda unida a la vértebra T3 y esternón.",Peso=67.37,Densidad=15.37,Longitud=19.08,Diametro=1.95},
                new Hueso(){Nombre="Costilla verdedera derecha unida a la vértebra T3 y esternón.",Peso=65.14,Densidad=16.25,Longitud=9.39,Diametro=1.77},
                new Hueso(){Nombre="Costilla verdedera izquierda unida a la vértebra T4 y esternón.",Peso=53.69,Densidad=16.74,Longitud=16.83,Diametro=3.01},
                new Hueso(){Nombre="Costilla verdedera derecha unida a la vértebra T4 y esternón.",Peso=57.22,Densidad=19.81,Longitud=11.37,Diametro=2.28},
                new Hueso(){Nombre="Costilla verdedera izquierda unida a la vértebra T5 y esternón.",Peso=11.13,Densidad=18.71,Longitud=17.72,Diametro=3.12},
                new Hueso(){Nombre="Costilla verdedera derecha unida a la vértebra T5 y esternón.",Peso=53.52,Densidad=17.45,Longitud=11.76,Diametro=2.81},
                new Hueso(){Nombre="Costilla verdedera izquierda unida a la vértebra T6 y esternón.",Peso=43.97,Densidad=4.96,Longitud=16.7,Diametro=2.71},
                new Hueso(){Nombre="Costilla verdedera derecha unida a la vértebra T6 y esternón.",Peso=46.86,Densidad=7.81,Longitud=8.06,Diametro=4.40},
                new Hueso(){Nombre="Costilla verdedera izquierda unida a la vértebra T7 y esternón.",Peso=55.21,Densidad=4.48,Longitud=7.43,Diametro=4.89},
                new Hueso(){Nombre="Costilla verdedera derecha unida a la vértebra T7 y esternón.",Peso=30.83,Densidad=1.65,Longitud=16.5,Diametro=3.07},
                new Hueso(){Nombre="Costilla falsa izquierda unida a la vértebra T8 y la anterior costilla.",Peso=41.4,Densidad=7.96,Longitud=17.2,Diametro=1.32},
                new Hueso(){Nombre="Costilla falsa derecha unida a la vértebra T8 y la anterior costilla.",Peso=53.57,Densidad=9.7,Longitud=9.74,Diametro=2.51},
                new Hueso(){Nombre="Costilla falsa izquierda unida a la vértebra T9 y la anterior costilla.",Peso=61.22,Densidad=9.99,Longitud=9.27,Diametro=4.54},
                new Hueso(){Nombre="Costilla falsa derecha unida a la vértebra T9 y la anterior costilla.",Peso=69.76,Densidad=6.97,Longitud=6.71,Diametro=3.48},
                new Hueso(){Nombre="Costilla falsa izquierda unida a la vértebra T10 y la anterior costilla.",Peso=13.65,Densidad=2.03,Longitud=5.35,Diametro=3.00},
                new Hueso(){Nombre="Costilla falsa derecha unida a la vértebra T10 y la anterior costilla.",Peso=42.83,Densidad=14.33,Longitud=6.86,Diametro=1.38},
                new Hueso(){Nombre="Costilla falsa flotante izquierda unida a la vértebra T11.",Peso=12.77,Densidad=12.19,Longitud=15.85,Diametro=4.66},
                new Hueso(){Nombre="Costilla falsa flotante derecha unida a la vértebra T11.",Peso=20.89,Densidad=6.32,Longitud=5.55,Diametro=3.76},
                new Hueso(){Nombre="Costilla falsa flotante izquierda unida a la vértebra T12.",Peso=20.55,Densidad=16.9,Longitud=19.76,Diametro=4.62},
                new Hueso(){Nombre="Costilla falsa flotante derecha unida a la vértebra T12.",Peso=17.36,Densidad=5.44,Longitud=13.46,Diametro=4.70},
                new Hueso(){Nombre="Omóplato o Escápula izquierdo.",Peso=57.11,Densidad=10.38,Longitud=14.45,Diametro=4.86},
                new Hueso(){Nombre="Omóplato o Escápula derecho.",Peso=23.04,Densidad=4.74,Longitud=6.55,Diametro=2.92},
                new Hueso(){Nombre="Clavicula izquierda.",Peso=54.43,Densidad=12.19,Longitud=10.36,Diametro=4.27},
                new Hueso(){Nombre="Clavicula derecha.",Peso=20.59,Densidad=15.79,Longitud=12.75,Diametro=4.13},
                new Hueso(){Nombre="Húmero izquierdo.",Peso=33.71,Densidad=15.38,Longitud=8.03,Diametro=1.29},
                new Hueso(){Nombre="Húmero derecho.",Peso=20.81,Densidad=15.89,Longitud=17.98,Diametro=2.17},
                new Hueso(){Nombre="Cúbito o Ulna izquierdo.",Peso=65.09,Densidad=1.83,Longitud=16.03,Diametro=4.83},
                new Hueso(){Nombre="Cúbito o Ulna derecho.",Peso=17.77,Densidad=14.13,Longitud=6.61,Diametro=2.48},
                new Hueso(){Nombre="Radio izquierdo.",Peso=57.32,Densidad=5.84,Longitud=7.73,Diametro=3.24},
                new Hueso(){Nombre="Radio derecho.",Peso=43.81,Densidad=15.84,Longitud=5.8,Diametro=4.37},
                new Hueso(){Nombre="Escafoides izquierdo.",Peso=30.96,Densidad=6.62,Longitud=12.37,Diametro=3.34},
                new Hueso(){Nombre="Escafoides derecho.",Peso=50.82,Densidad=19.42,Longitud=16.19,Diametro=4.43},
                new Hueso(){Nombre="Semilunar izquierdo.",Peso=44.25,Densidad=13.81,Longitud=5.01,Diametro=3.51},
                new Hueso(){Nombre="Semilunar derecho.",Peso=39.37,Densidad=17.66,Longitud=9.96,Diametro=2.94},
                new Hueso(){Nombre="Piramidal izquierdo.",Peso=62.11,Densidad=5.04,Longitud=9.76,Diametro=2.16},
                new Hueso(){Nombre="Piramidal derecho.",Peso=18.59,Densidad=11.77,Longitud=19.05,Diametro=3.43},
                new Hueso(){Nombre="Pisiforme izquierdo.",Peso=22.35,Densidad=16.84,Longitud=17.04,Diametro=1.61},
                new Hueso(){Nombre="Pisiforme derecho.",Peso=12.51,Densidad=9.14,Longitud=13.51,Diametro=1.10},
                new Hueso(){Nombre="Ganchoso izquierdo.",Peso=38.59,Densidad=19.67,Longitud=6,Diametro=3.85},
                new Hueso(){Nombre="Ganchoso derecho.",Peso=39.86,Densidad=17.78,Longitud=10.3,Diametro=3.40},
                new Hueso(){Nombre="Grande izquierdo.",Peso=57.15,Densidad=17.85,Longitud=13.22,Diametro=4.33},
                new Hueso(){Nombre="Grande derecho.",Peso=51.86,Densidad=9.46,Longitud=7.78,Diametro=1.42},
                new Hueso(){Nombre="Trapezoide izquierdo.",Peso=13.03,Densidad=11.79,Longitud=7.22,Diametro=2.43},
                new Hueso(){Nombre="Trapezoide derecho.",Peso=66.37,Densidad=9.87,Longitud=7.62,Diametro=4.27},
                new Hueso(){Nombre="Trapecio izquierdo.",Peso=35.36,Densidad=11.35,Longitud=8.91,Diametro=3.60},
                new Hueso(){Nombre="Trapecio derecho.",Peso=61.15,Densidad=17.32,Longitud=12.49,Diametro=3.48},
                new Hueso(){Nombre="Metacarpio 1 dedo pulgar izquierdo.",Peso=17.45,Densidad=19.41,Longitud=12.24,Diametro=4.62},
                new Hueso(){Nombre="Metacarpio 1 dedo pulgar derecho.",Peso=42.9,Densidad=3.39,Longitud=16.5,Diametro=4.39},
                new Hueso(){Nombre="Falange 1 del dedo pulgar izquierdo.",Peso=28.91,Densidad=10.34,Longitud=11.06,Diametro=3.32},
                new Hueso(){Nombre="Falange 1 del dedo pulgar derecho.",Peso=21.45,Densidad=1.62,Longitud=11.31,Diametro=3.48},
                new Hueso(){Nombre="Falange 2 del dedo pulgar izquierdo.",Peso=36.69,Densidad=1.74,Longitud=13.29,Diametro=2.72},
                new Hueso(){Nombre="Falange 2 del dedo pulgar derecho.",Peso=15.19,Densidad=13.3,Longitud=10.14,Diametro=2.82},
                new Hueso(){Nombre="Metacarpio 2 dedo índice izquierdo.",Peso=58.06,Densidad=4.36,Longitud=8.18,Diametro=4.82},
                new Hueso(){Nombre="Metacarpio 2 dedo índice derecho.",Peso=40.96,Densidad=12.46,Longitud=7.56,Diametro=2.65},
                new Hueso(){Nombre="Falange 1 del dedo índice izquierdo.",Peso=15.98,Densidad=8.17,Longitud=5.22,Diametro=1.74},
                new Hueso(){Nombre="Falange 1 del dedo índice derecho.",Peso=42.05,Densidad=14.16,Longitud=9.72,Diametro=1.23},
                new Hueso(){Nombre="Falange 2 del dedo índice izquierdo.",Peso=16.49,Densidad=19.65,Longitud=13.33,Diametro=3.67},
                new Hueso(){Nombre="Falange 2 del dedo índice derecho.",Peso=56.05,Densidad=3.58,Longitud=10.44,Diametro=4.11},
                new Hueso(){Nombre="Falange 3 del dedo índice izquierdo.",Peso=68.33,Densidad=8.96,Longitud=13.22,Diametro=3.77},
                new Hueso(){Nombre="Falange 3 del dedo índice derecho.",Peso=50.6,Densidad=14.33,Longitud=19.55,Diametro=3.04},
                new Hueso(){Nombre="Metacarpio 3 dedo corazón izquierdo.",Peso=49.36,Densidad=14.45,Longitud=18.32,Diametro=1.37},
                new Hueso(){Nombre="Metacarpio 3 dedo corazón derecho.",Peso=46.97,Densidad=17.22,Longitud=5.04,Diametro=2.16},
                new Hueso(){Nombre="Falange 1 del dedo corazón izquierdo.",Peso=38.01,Densidad=13.13,Longitud=15.57,Diametro=3.37},
                new Hueso(){Nombre="Falange 1 del dedo corazón derecho.",Peso=67.3,Densidad=9.52,Longitud=17.73,Diametro=1.00},
                new Hueso(){Nombre="Falange 2 del dedo corazón izquierdo.",Peso=22.45,Densidad=18.74,Longitud=5.69,Diametro=4.71},
                new Hueso(){Nombre="Falange 2 del dedo corazón derecho.",Peso=31.39,Densidad=7.48,Longitud=5.43,Diametro=2.29},
                new Hueso(){Nombre="Falange 3 del dedo corazón izquierdo.",Peso=10.92,Densidad=19.11,Longitud=8.72,Diametro=1.62},
                new Hueso(){Nombre="Falange 3 del dedo corazón derecho.",Peso=49.24,Densidad=8.28,Longitud=11.05,Diametro=4.85},
                new Hueso(){Nombre="Metacarpio 4 dedo anular izquierdo.",Peso=55.14,Densidad=18.88,Longitud=11.6,Diametro=1.97},
                new Hueso(){Nombre="Metacarpio 4 dedo anular derecho.",Peso=52.46,Densidad=10.42,Longitud=7.3,Diametro=4.26},
                new Hueso(){Nombre="Falange 1 del dedo anular izquierdo.",Peso=24.95,Densidad=7.36,Longitud=8.97,Diametro=2.58},
                new Hueso(){Nombre="Falange 1 del dedo anular derecho.",Peso=10.97,Densidad=14.82,Longitud=19.8,Diametro=2.37},
                new Hueso(){Nombre="Falange 2 del dedo anular izquierdo.",Peso=22.63,Densidad=18.24,Longitud=12.34,Diametro=3.82},
                new Hueso(){Nombre="Falange 2 del dedo anular derecho.",Peso=43.79,Densidad=10.39,Longitud=13.17,Diametro=1.91},
                new Hueso(){Nombre="Falange 3 del dedo anular izquierdo.",Peso=18.79,Densidad=2.56,Longitud=12.22,Diametro=3.17},
                new Hueso(){Nombre="Falange 3 del dedo anular derecho.",Peso=60.23,Densidad=13.27,Longitud=11.71,Diametro=3.54},
                new Hueso(){Nombre="Metacarpio 5 dedo meñique izquierdo.",Peso=49.59,Densidad=19.79,Longitud=9.63,Diametro=4.71},
                new Hueso(){Nombre="Metacarpio 5 dedo meñique derecho.",Peso=36.34,Densidad=6.91,Longitud=5.09,Diametro=4.83},
                new Hueso(){Nombre="Falange 1 del dedo meñique izquierdo.",Peso=26.21,Densidad=9.41,Longitud=8.84,Diametro=2.15},
                new Hueso(){Nombre="Falange 1 del dedo meñique derecho.",Peso=32.08,Densidad=3.69,Longitud=17.61,Diametro=4.93},
                new Hueso(){Nombre="Falange 2 del dedo meñique izquierdo.",Peso=17.17,Densidad=16.5,Longitud=10.99,Diametro=2.78},
                new Hueso(){Nombre="Falange 2 del dedo meñique derecho.",Peso=53.59,Densidad=2.5,Longitud=5.27,Diametro=3.01},
                new Hueso(){Nombre="Falange 3 del dedo meñique izquierdo.",Peso=15.43,Densidad=8.74,Longitud=16.67,Diametro=2.39},
                new Hueso(){Nombre="Falange 3 del dedo meñique derecho. ",Peso=54.57,Densidad=19.08,Longitud=11.2,Diametro=1.28},
                new Hueso(){Nombre="Coxal izquierdo.",Peso=67.05,Densidad=9.04,Longitud=7.12,Diametro=1.19},
                new Hueso(){Nombre="Coxal derecho.",Peso=63.82,Densidad=16.79,Longitud=17.19,Diametro=2.31},
                new Hueso(){Nombre="Fémur izquierdo.",Peso=38.03,Densidad=8.2,Longitud=16.94,Diametro=4.93},
                new Hueso(){Nombre="Fémur derecho.",Peso=21.69,Densidad=4.57,Longitud=13.11,Diametro=3.85},
                new Hueso(){Nombre="Rótula izquierda.",Peso=39.81,Densidad=3.09,Longitud=15.96,Diametro=2.11},
                new Hueso(){Nombre="Rótula derecha.",Peso=16.82,Densidad=3.9,Longitud=5.16,Diametro=3.82},
                new Hueso(){Nombre="Tibia izquierda.",Peso=55.24,Densidad=9.92,Longitud=17.48,Diametro=4.26},
                new Hueso(){Nombre="Tibia derecha.",Peso=13.93,Densidad=13.19,Longitud=17.23,Diametro=3.94},
                new Hueso(){Nombre="Peroné izquierdo.",Peso=52.38,Densidad=16.91,Longitud=6.1,Diametro=2.39},
                new Hueso(){Nombre="Peroné derecho.",Peso=44.17,Densidad=12.06,Longitud=11.82,Diametro=3.70},
                new Hueso(){Nombre="Calcáneo izquierdo.",Peso=49.33,Densidad=16.76,Longitud=19.94,Diametro=1.91},
                new Hueso(){Nombre="Calcáneo derecho.",Peso=40.84,Densidad=11.94,Longitud=14.03,Diametro=3.37},
                new Hueso(){Nombre="Astrágalo izquierdo.",Peso=18.12,Densidad=5.25,Longitud=12.01,Diametro=3.38},
                new Hueso(){Nombre="Astrágalo derecho.",Peso=40.6,Densidad=16.28,Longitud=7.66,Diametro=3.77},
                new Hueso(){Nombre="Cuboides izquierdo.",Peso=66.88,Densidad=10.62,Longitud=11.83,Diametro=2.14},
                new Hueso(){Nombre="Cuboides derecho.",Peso=59.97,Densidad=3.42,Longitud=15.55,Diametro=2.22},
                new Hueso(){Nombre="Escafoides izquierdo.",Peso=48.61,Densidad=11.04,Longitud=8.88,Diametro=1.33},
                new Hueso(){Nombre="Escafoides derecho.",Peso=63.98,Densidad=16.26,Longitud=10.96,Diametro=2.07},
                new Hueso(){Nombre="Cuneiformes 1 izquierdo.",Peso=64.78,Densidad=11.72,Longitud=10.6,Diametro=4.38},
                new Hueso(){Nombre="Cuneiformes 1 derecho.",Peso=15.6,Densidad=6.65,Longitud=7.62,Diametro=3.97},
                new Hueso(){Nombre="Cuneiformes 2 izquierdo.",Peso=63.76,Densidad=18.03,Longitud=17.46,Diametro=3.35},
                new Hueso(){Nombre="Cuneiformes 2 derecho.",Peso=63.39,Densidad=10.43,Longitud=9.4,Diametro=1.14},
                new Hueso(){Nombre="Cuneiformes 3 izquierdo.",Peso=29,Densidad=1.83,Longitud=9.32,Diametro=1.66},
                new Hueso(){Nombre="Cuneiformes 3 derecho.",Peso=30.6,Densidad=5.34,Longitud=14.47,Diametro=2.66},
                new Hueso(){Nombre="Metatarsiano 1 dedo 1 izquierdo.",Peso=12.22,Densidad=16.87,Longitud=18.75,Diametro=1.24},
                new Hueso(){Nombre="Metatarsiano 1 dedo 1 derecho.",Peso=44.77,Densidad=10.88,Longitud=7.21,Diametro=1.19},
                new Hueso(){Nombre="Falange 1 del dedo 1 izquierdo.",Peso=35.53,Densidad=9.03,Longitud=5.74,Diametro=2.18},
                new Hueso(){Nombre="Falange 1 del dedo 1 derecho.",Peso=38.2,Densidad=8.19,Longitud=13.71,Diametro=2.34},
                new Hueso(){Nombre="Falange 2 del dedo 1 izquierdo.",Peso=57.78,Densidad=5.71,Longitud=5.19,Diametro=4.96},
                new Hueso(){Nombre="Falange 2 del dedo 1 derecho.",Peso=13.45,Densidad=7.43,Longitud=15.49,Diametro=1.22},
                new Hueso(){Nombre="Metatarsiano 2 dedo 2 izquierdo.",Peso=50.22,Densidad=18.73,Longitud=17.96,Diametro=4.46},
                new Hueso(){Nombre="Metatarsiano 2 dedo 2 derecho.",Peso=30.34,Densidad=1.54,Longitud=15.2,Diametro=2.77},
                new Hueso(){Nombre="Falange 1 del dedo 2 izquierdo.",Peso=19.36,Densidad=8.21,Longitud=7.4,Diametro=3.20},
                new Hueso(){Nombre="Falange 1 del dedo 2 derecho.",Peso=20.22,Densidad=11.39,Longitud=9.94,Diametro=3.00},
                new Hueso(){Nombre="Falange 2 del dedo 2 izquierdo.",Peso=56.06,Densidad=8.45,Longitud=16.7,Diametro=3.88},
                new Hueso(){Nombre="Falange 2 del dedo 2 derecho.",Peso=69.2,Densidad=18.5,Longitud=14.67,Diametro=4.83},
                new Hueso(){Nombre="Falange 3 del dedo 2 izquierdo.",Peso=21.29,Densidad=1.61,Longitud=17.92,Diametro=3.84},
                new Hueso(){Nombre="Falange 3 del dedo 2 derecho.",Peso=44.97,Densidad=9.61,Longitud=14.37,Diametro=3.25},
                new Hueso(){Nombre="Metatarsiano3 dedo 3 izquierdo.",Peso=25.56,Densidad=14.03,Longitud=13.68,Diametro=4.05},
                new Hueso(){Nombre="Metatarsiano3 dedo 3 derecho.",Peso=50.7,Densidad=15.17,Longitud=13.17,Diametro=3.80},
                new Hueso(){Nombre="Falange 1 del dedo 3 izquierdo.",Peso=42.02,Densidad=19.73,Longitud=5.87,Diametro=2.59},
                new Hueso(){Nombre="Falange 1 del dedo 3 derecho.",Peso=33.82,Densidad=5.43,Longitud=19.43,Diametro=3.98},
                new Hueso(){Nombre="Falange 2 del dedo 3 izquierdo.",Peso=47.29,Densidad=1.76,Longitud=11.07,Diametro=2.59},
                new Hueso(){Nombre="Falange 2 del dedo 3 derecho.",Peso=39.1,Densidad=15.45,Longitud=18.71,Diametro=4.76},
                new Hueso(){Nombre="Falange 3 del dedo 3 izquierdo.",Peso=25,Densidad=15.28,Longitud=17.14,Diametro=3.45},
                new Hueso(){Nombre="Falange 3 del dedo 3 derecho.",Peso=29.9,Densidad=4.16,Longitud=19.18,Diametro=2.81},
                new Hueso(){Nombre="Metatarsiano4 dedo 4 izquierdo.",Peso=45.8,Densidad=19.99,Longitud=16.09,Diametro=2.67},
                new Hueso(){Nombre="Metatarsiano4 dedo 4 derecho.",Peso=42,Densidad=4.63,Longitud=18.5,Diametro=3.37},
                new Hueso(){Nombre="Falange 1 del dedo 4 izquierdo.",Peso=23.73,Densidad=5.13,Longitud=11.56,Diametro=1.93},
                new Hueso(){Nombre="Falange 1 del dedo 4 derecho.",Peso=57.65,Densidad=14.1,Longitud=8.59,Diametro=4.52},
                new Hueso(){Nombre="Falange 2 del dedo 4 izquierdo.",Peso=59.36,Densidad=17.7,Longitud=10.77,Diametro=2.94},
                new Hueso(){Nombre="Falange 2 del dedo 4 derecho.",Peso=58.39,Densidad=7.39,Longitud=5.91,Diametro=2.78},
                new Hueso(){Nombre="Falange 3 del dedo 4 izquierdo.",Peso=34.78,Densidad=2.14,Longitud=9.51,Diametro=1.27},
                new Hueso(){Nombre="Falange 3 del dedo 4 derecho.",Peso=46.11,Densidad=3.8,Longitud=8.77,Diametro=4.29},
                new Hueso(){Nombre="Metatarsiano5 dedo 5 izquierdo.",Peso=42.83,Densidad=1.44,Longitud=10.15,Diametro=1.30},
                new Hueso(){Nombre="Metatarsiano5 dedo 5 derecho.",Peso=21.26,Densidad=18.36,Longitud=14.65,Diametro=1.06},
                new Hueso(){Nombre="Falange 1 del dedo 5 izquierdo.",Peso=59.85,Densidad=19.39,Longitud=17.42,Diametro=2.05},
                new Hueso(){Nombre="Falange 1 del dedo 5 derecho.",Peso=33.51,Densidad=19.47,Longitud=14.99,Diametro=1.21},
                new Hueso(){Nombre="Falange 2 del dedo 5 izquierdo.",Peso=36.19,Densidad=13.25,Longitud=6.11,Diametro=2.14},
                new Hueso(){Nombre="Falange 2 del dedo 5 derecho.",Peso=39.14,Densidad=6.85,Longitud=12.49,Diametro=2.09},
                new Hueso(){Nombre="Falange 3 del dedo 5 izquierdo.",Peso=37.75,Densidad=4.88,Longitud=14.92,Diametro=1.91},
                new Hueso(){Nombre="Falange 3 del dedo 5 derecho.",Peso=18.66,Densidad=4.33,Longitud=5.96,Diametro=2.35},
            };
        }
        public void Ordenar(string cadenaOrden)
        {
            switch (cadenaOrden)
            {
                case "Nombre_desc":
                    Huesos = Huesos?.OrderByDescending(s => s.Nombre).ToList();
                    break;
                case "Nombre_asc":
                    Huesos = Huesos?.OrderBy(s => s.Nombre).ToList();
                    break;
                case "Peso_desc":
                    Huesos = Huesos?.OrderByDescending(s => s.Peso).ToList();
                    break;
                case "Peso_asc":
                    Huesos = Huesos?.OrderBy(s => s.Peso).ToList();
                    break;
                case "Densidad_desc":
                    Huesos = Huesos?.OrderByDescending(s => s.Densidad).ToList();
                    break;
                case "Densidad_asc":
                    Huesos = Huesos?.OrderBy(s => s.Densidad).ToList();
                    break;
                case "Longitud_desc":
                    Huesos = Huesos?.OrderByDescending(s => s.Longitud).ToList();
                    break;
                case "Longitud_asc":
                    Huesos = Huesos?.OrderBy(s => s.Longitud).ToList();
                    break;
                case "Diametro_desc":
                    Huesos = Huesos?.OrderByDescending(s => s.Diametro).ToList();
                    break;
                case "Diametro_asc":
                    Huesos = Huesos?.OrderBy(s => s.Diametro).ToList();
                    break;
                default:
                    Huesos = Huesos?.OrderByDescending(s => s.Nombre).ToList();
                    break;

            }
        }
        public List<Hueso>? Imprimir()
        {
            return Huesos?.ToList();
        }
    }
}

