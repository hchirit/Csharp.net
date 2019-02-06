package Geometries;

import Primitives.Point3D;
import Primitives.Ray;
import Primitives.Vector;
import org.junit.Test;

import java.util.List;

import static org.junit.Assert.*;

/**
 * Created by HC on 29/06/2017.
 */

public class TriangleTest {
    @Test
    public void triangleTest(){
        Triangle trg = new Triangle(new Point3D(4, -4, 4), new Point3D(-3, 3, 5), new Point3D(5, 2, 5));
        Point3D pt = new Point3D(0.9, 1.9, 4.9);
        Ray ray = new Ray(pt, new Vector(0, 0, 1));
        List<Point3D> rayIntersectionPoints1 = trg.FindIntersections(ray);
    }
}