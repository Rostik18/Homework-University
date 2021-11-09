package rosty

import org.apache.spark.SparkConf
import org.apache.spark.sql.SparkSession

import scala.util.Properties

object DockerUtils {

  def getSparkSession(appName: String): SparkSession = {

    val conf = new SparkConf

    conf.set("spark.master", Properties.envOrElse("SPARK_MASTER_URL", "spark://127.0.0.1:7077"))
    conf.set("spark.driver.host", Properties.envOrElse("SPARK_DRIVER_HOST", "SparkHost"))
    conf.set("spark.submit.deployMode", "client")
    conf.set("spark.driver.bindAddress", "0.0.0.0")
    conf.set("spark.shuffle.service.enabled", "false")
    conf.set("spark.dynamicAllocation.enabled", "false")


    conf.set("spark.app.name", appName)

    SparkSession.builder.config(conf = conf).getOrCreate()
  }
}