package test;

import Elements.SpotLight;
import Geometries.Rectangle;
import Geometries.Sphere;
import Primitives.Point3D;
import Primitives.Vector;
import Renderer.ImageWriter;
import Renderer.Render;
import Scene.Scene;
import org.junit.Test;

import java.awt.*;

import static org.junit.Assert.*;

/**
 * Created by HC on 23/06/2017.
 */
public class ShadowTest {
    @Test
    public void shadowTest(){
        Scene scene = new Scene();

        Rectangle rectangle = new Rectangle(new Point3D(-600, -900, -400), new Point3D(700, 600,-500));
        rectangle.setEmmission(new Color(40, 40, 60));
        scene.addGeometry(rectangle);


        Sphere sphere = new Sphere(400, new Point3D(20, 0.0, -500));
        sphere.setShininess(20);
        sphere.setEmmission(new Color(0, 0, 100));

        scene.addGeometry(sphere);




        scene.addLight(new SpotLight(new Color(255, 100, 100), new Point3D(200, 200, -100),
                new Vector(-2, -2, -3), 0, 0.000001, 0.0000005));


        ImageWriter imageWriter = new ImageWriter("shadow test", 500, 500, 500, 500);

        Render render = new Render(imageWriter, scene);

        render.renderImage();
        render.writeToImage();

    }

}