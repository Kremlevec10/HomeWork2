// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// sqrt(x2-x1)*2+(y2-y1)*2+(z2-z1)*2




double distance = distancePoints(3,6,8,2,1,-7);

double distancePoints(int x1, int y1,int z1, int x2,int y2,int z2) {
    int x = x2-x1, y = y2 -y1, z = z2-z1;
    return Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2)+Math.Pow(z,2));
}
