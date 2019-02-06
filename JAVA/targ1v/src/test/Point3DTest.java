package test;

import Primitives.Point3D;
import org.junit.Test;
import Primitives.Vector;
import org.junit.Assert;



/**
 * Created by HC on 04/05/2017.
 */
public class Point3DTest {

    Point3D point =new Point3D(3,2,-5);
    int result;

    @Test
    public void TestToString() {
       String s=point.toString();
       Point3D p=new Point3D(3.00,2.00,-5.00);
       Assert.assertTrue(p.toString().compareTo(s)==0);
       Assert.assertEquals("essai", p, "(3,00, 2,00, -5,00)");
}

    @Test
    public void TestCompareTo()  {
    result=point.compareTo(new Point3D(3,2,-5));
    Assert.assertTrue(result==0);

    }

    @Test
    public void TestAdd() {
        point.add(new Vector(5,5,5));
        result=point.compareTo(new Point3D(3+5,2+5,-5+5));
        Assert.assertTrue(result==0);
    }

    @Test
    public void TestSubstract() {
        point.substract(new Vector(3,2,-5));
        result=point.compareTo(new Point3D(0,0,0));
        Assert.assertTrue(result==0);
    }

    @Test
    public void TestDistance() {
       double results= point.distance(new Point3D(3,2,-5));
        Assert.assertTrue(result==0);
    }

}