package test;

import org.junit.Test;
import Geometries.*;
import Primitives.*;
import Scene.Scene;
import Renderer.*;
import Elements.*;


import java.awt.*;

import static org.junit.Assert.*;

/**
 * Created by HC on 13/06/2017.
 */
public class RenderTest {
    @Test
    public void basicRender()  {
        Scene scene = new Scene();
        scene.setScreenDistance(35);

        Sphere sphere = new Sphere(40, new Point3D(0.0, 0.0, -53));

       Triangle triangle = new Triangle(new Point3D( 100, 0, -55), new Point3D(  0, 100, -55), new Point3D( 100, 100, -55));

       Triangle triangle2 = new Triangle(new Point3D( 100, 0, -49), new Point3D(  0, -100, -49), new Point3D( 100,-100, -49));

       Triangle triangle3 = new Triangle(new Point3D(-100, 0, -49), new Point3D(  0, 100, -49), new Point3D(-100, 100, -49));

       Triangle triangle4 = new Triangle(new Point3D(-80, 40, -49), new Point3D(  20,  -60, -49), new Point3D(-80, -60, -49));

       triangle.setEmmission(new Color(255, 255, 255));
       triangle2.setEmmission(new Color(255, 0, 0));
       triangle3.setEmmission(new Color(0, 255, 0));
        triangle4.setEmmission(new Color(103, 129, 255));
sphere.setEmmission(new Color(199, 49,255));

        scene.addGeometry(sphere);
        scene.addGeometry(triangle);
        scene.addGeometry(triangle2);
        scene.addGeometry(triangle3);
        scene.addGeometry(triangle4);

        //scene.addLight(new SpotLight(new Color(255, 199, 135),new Point3D(100,100,-100),new Vector(-2,-2,-3),0,0.000001,0.00001));
        ImageWriter imageWriter = new ImageWriter("Render test", 500, 500, 500, 500);

        Render render = new Render(imageWriter, scene);

        render.renderImage();
        render.printGrid(15);
        render.writeToImage();

    }

}

