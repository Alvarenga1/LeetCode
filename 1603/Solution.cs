namespace _1603;
public class ParkingSystem
{
    int[] carSpaces = new int[3];


    public ParkingSystem(int big, int medium, int small)
    {
        this.carSpaces[0] = big;
        this.carSpaces[1] = medium;
        this.carSpaces[2] = small;
    }

    public bool AddCar(int carType)
    {
        if (carSpaces[carType - 1] > 0)
        {
            carSpaces[carType - 1]--;
            return true;
        }
        return false;
    }
}