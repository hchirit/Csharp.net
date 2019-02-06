package test;



import org.junit.Assert;
import org.junit.Test;
import Primitives.Vector;

/**
 * Created by HC on 01/05/2017.
 */
public class VectorTest {
    Vector V=new Vector(1,1,1);
    double result;
    @Test
    public void TestAdd()  {
        V.add(new Vector(1,1,1));
        result=V.compareTo(new Vector(2,2,2));
        Assert.assertTrue(result==0);

    }

    @org.junit.Test
    public void subtract()  {
        V.subtract(new Vector(1,1,1));
        result=V.compareTo(new Vector(0,0,0));
        Assert.assertTrue(result==0);
    }

    @org.junit.Test
    public void scale() {
        V.scale(2);
        result=V.compareTo(new Vector(2,2,2));
        Assert.assertTrue(result==0);
    }

    //cross:(u2v3-u3v2,u3v1-u1v3,u1v2-u2v1)
    @org.junit.Test
    public void crossProduct() {
        Vector V1=V.crossProduct(new Vector(1,1,1));
        result=V1.compareTo(new Vector(0,0,0));
        Assert.assertTrue(result==0);
    }

    @org.junit.Test
    public void length() {
         double lenghVector =V.length();
         result=lenghVector-(new Vector(1,1,1).length());
         Assert.assertTrue(result==0);
    }

    @org.junit.Test
    public void testNormalize()  {
        Vector v = new Vector(3.5,-5,10);
        v.normalize();
        Assert.assertEquals("", 1, v.length(),1e-10);
        v = new Vector(0,0,0);
        try {
            v.normalize();
            Assert.fail("Didn't throw divide by zero exception!");
        } catch (ArithmeticException e) {
            Assert.assertTrue(true);
        }
    }

    @org.junit.Test
    public void dotProduct() {
        double dot=V.dotProduct(new Vector(2,2,3));
        result=dot-7;
        Assert.assertTrue(result==0);
    }

}