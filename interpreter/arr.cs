//Compressed boolean

using System;
public class CompressedBoolean
{
    //[0 0 0 0 0 0 1 1]
    //Now get the first element by doing this
    //[0 0 0 0 0 0 1 1] ^ [0 0 0 0 0 0 0 1]
    //This cancels all but the one with zeroes,
    //either the last one will be 1 or zero

    byte arr;

    public CompressedBoolean()
    {
        arr = 0;
    }

    private byte getMask(int index)
    {
        byte mask = (byte)System.Math.Pow(2, index);
        //I can;t do a bit shift in C# apparently
        // for(int i = 0; i < index;i++)
        // {
        //     mask <<< ;
        // }
        return mask;
    }

    //To set one we do this
    public void setBoolean(int index, bool value)
    {
        //Calculate the mask for each index and then one for the new one (if setting to true)
        //and add them all toghether

        if (value)
        {
            //Get the mask for an on bit
            byte mask = getMask(index);

            byte total = 0;

            for (int i = 0; i < 8; i++)
            {
                //If the index is true then add it and not the one we are setting to true
                if (getBoolean(i) && i != index)
                {
                    total = (byte)(total + getMask(i));
                }
            }

            //Add the trued mask
            total = (byte)(total + getMask(index));
            arr = total;
        }
        else
        {
            //Get the mask for an on bit
            byte mask = getMask(index);

            byte total = 0;

            for (int i = 0; i < 8; i++)
            {
                //If the index is true then add it and not the one we are setting to false4
                if (getBoolean(i) && i != index)
                {
                    total = (byte)(total + getMask(i));
                }
            }

            //Add the trued mask
            //total=(byte)(total+getMask(index));
            arr = total;
        }
    }

    public bool getBoolean(int index)
    {
        //The current array anded with the mask
        //e.g. if we have [0 0 0 0 0 0 0 1]
        //then [0 0 0 0 0 0 0 1] ^ [0 0 0 0 0 0 0 1]
        //is [0 0 0 0 0 0 0 1]
        byte temp = (byte)(arr & getMask(index));
        //Console.Out.WriteLine(temp);
        if (temp == 0)
        {
            return false;
        }
        else
        {
            return true;
        }

    }
}