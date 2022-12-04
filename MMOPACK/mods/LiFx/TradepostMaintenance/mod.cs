/**
* <author>Christophe Roblin</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no>, Warped Ibun <madbrit@co.uk></credits>
* <description>knools from mmo introduced to Lif:YO</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(lifx_TradepostAutoMaintain))
{
  new ScriptObject(lifx_TradepostAutoMaintain)
  {
  };
}

package lifx_TradepostAutoMaintain

{
  function lifx_TradepostAutoMaintain::setup() {
   LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, Dbchanges, lifx_TradepostAutoMaintain);
  }
  
  function lifx_TradepostAutoMaintain::dbChanges() {
     //update Tradepost and clean up every restart
     //fixed sales - Crown sells
  dbi.Update("TRUNCATE TABLE `nyu_tradepost_market`");
  //knool Weapons
  dbi.Update("INSERT IGNORE `nyu_tradepost_market` VALUES (NULL, 'SELL', 'FIXED', 2465, NULL, NULL, 100, 0, 20000, 130000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)");
  dbi.Update("INSERT IGNORE `nyu_tradepost_market` VALUES (NULL, 'SELL', 'FIXED', 2466, NULL, NULL, 100, 0, 20000, 125000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)");
  dbi.Update("INSERT IGNORE `nyu_tradepost_market` VALUES (NULL, 'SELL', 'FIXED', 2464, NULL, NULL, 100, 0, 20000, 132000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)");
  dbi.Update("INSERT IGNORE `nyu_tradepost_market` VALUES (NULL, 'SELL', 'FIXED', 2463, NULL, NULL, 100, 0, 20000, 120000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)");
  dbi.Update("INSERT IGNORE `nyu_tradepost_market` VALUES (NULL, 'SELL', 'FIXED', 2462, NULL, NULL, 100, 0, 20000, 150000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)");
  dbi.Update("INSERT IGNORE `nyu_tradepost_market` VALUES (NULL, 'SELL', 'FIXED', 2461, NULL, NULL, 100, 0, 20000, 120000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)");
/*  //end of knool weapons
  dbi.Update("INSERT IGNORE `nyu_tradepost_market` VALUES (NULL, 'SELL', 'FIXED', 424, 13, 100, 0, 20000, 3000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)");
  dbi.Update("INSERT IGNORE `nyu_tradepost_market` VALUES (NULL, 'SELL', 'FIXED', 424, 14, 100, 0, 20000, 3000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)");
  dbi.Update("INSERT IGNORE `nyu_tradepost_market` VALUES (NULL, 'SELL', 'FIXED', 425, 12, 100, 0, 20000, 3000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)");
  dbi.Update("INSERT IGNORE `nyu_tradepost_market` VALUES (NULL, 'SELL', 'FIXED', 425, 13, 100, 0, 20000, 3000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)");
  dbi.Update("INSERT IGNORE `nyu_tradepost_market` VALUES (NULL, 'SELL', 'FIXED', 425, 14, 100, 0, 20000, 3000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)");
  dbi.Update("INSERT IGNORE `nyu_tradepost_market` VALUES (NULL, 'SELL', 'FIXED', 326, 12, 100, 0, 20000, 3000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)");
  dbi.Update("INSERT IGNORE `nyu_tradepost_market` VALUES (NULL, 'SELL', 'FIXED', 326, 13, 100, 0, 20000, 3000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)");
  dbi.Update("INSERT IGNORE `nyu_tradepost_market` VALUES (NULL, 'SELL', 'FIXED', 326, 14, 100, 0, 20000, 3000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)");
  dbi.Update("INSERT IGNORE `nyu_tradepost_market` VALUES (NULL, 'SELL', 'FIXED', 327, 12, 100, 0, 20000, 3000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)");
  dbi.Update("INSERT IGNORE `nyu_tradepost_market` VALUES (NULL, 'SELL', 'FIXED', 327, 13, 100, 0, 20000, 3000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)");
  dbi.Update("INSERT IGNORE `nyu_tradepost_market` VALUES (NULL, 'SELL', 'FIXED', 327, 14, 100, 0, 20000, 3000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)");
  dbi.Update("INSERT IGNORE `nyu_tradepost_market` VALUES (NULL, 'SELL', 'FIXED', 403, 12, 100, 0, 20000, 4000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)");
  dbi.Update("INSERT IGNORE `nyu_tradepost_market` VALUES (NULL, 'SELL', 'FIXED', 1685, NULL, 100, 0, 500, 5000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)");
  dbi.Update("INSERT IGNORE `nyu_tradepost_market` VALUES (NULL, 'SELL', 'FIXED', 1029, NULL, 100, 0, 20000, 10000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)");
  dbi.Update("INSERT IGNORE `nyu_tradepost_market` VALUES (NULL, 'SELL', 'FIXED', 1635, NULL, 100, 0, 20000, 10000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)");
  dbi.Update("INSERT IGNORE `nyu_tradepost_market` VALUES (NULL, 'SELL', 'FIXED', 1634, NULL, 100, 0, 20000, 5000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)");
  dbi.Update("INSERT IGNORE `nyu_tradepost_market` VALUES (NULL, 'SELL', 'FIXED', 1636, NULL, 100, 0, 20000, 15000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)");
*/

//vals Editions

dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 326, 12, NULL, 100, 0, 20000, 5500, 'timestamp', NULL, 15, 10, 3000, 7000, 80, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 326, 13, NULL, 100, 0, 20000, 5500, 'timestamp', NULL, 15, 10, 3000, 7000, 80, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 326, 14, NULL, 100, 0, 20000, 5500, 'timestamp', NULL, 15, 10, 3000, 7000, 80, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 327, 12, NULL, 100, 0, 20000, 5000, 'timestamp', NULL, 15, 10, 2000, 6000, 60, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 327, 13, NULL, 100, 0, 20000, 5000, 'timestamp', NULL, 15, 10, 2000, 6000, 60, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 327, 14, NULL, 100, 0, 20000, 5000, 'timestamp', NULL, 15, 10, 2000, 6000, 60, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 262, 12, NULL, 100, 0, 20000, 20000, 'timestamp', NULL, 55, 10, 4000, 20000, 160, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 262, 13, NULL, 100, 0, 20000, 20000, 'timestamp', NULL, 55, 10, 4000, 20000, 160, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 262, 14, NULL, 100, 0, 20000, 20000, 'timestamp', NULL, 55, 10, 4000, 20000, 160, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 425, 12, NULL, 100, 0, 20000, 3000, 'timestamp', NULL, 15, 10, 1000, 5000, 48, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 425, 13, NULL, 100, 0, 20000, 3000, 'timestamp', NULL, 15, 10, 1000, 5000, 48, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 425, 14, NULL, 100, 0, 20000, 3000, 'timestamp', NULL, 15, 10, 1000, 5000, 48, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 424, 12, NULL, 100, 0, 20000, 3500, 'timestamp', NULL, 15, 10, 1500, 6000, 54, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 424, 13, NULL, 100, 0, 20000, 3500, 'timestamp', NULL, 15, 10, 1500, 6000, 54, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 424, 14, NULL, 100, 0, 20000, 3500, 'timestamp', NULL, 15, 10, 1500, 6000, 54, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 402, 12, NULL, 100, 0, 20000, 6250, 'timestamp', NULL, 25, 10, 3000, 10000, 105, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 402, 13, NULL, 100, 0, 20000, 6250, 'timestamp', NULL, 25, 10, 3000, 10000, 105, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 402, 14, NULL, 100, 0, 20000, 6250, 'timestamp', NULL, 25, 10, 3000, 10000, 105, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 271, 12, NULL, 100, 0, 20000, 7500, 'timestamp', NULL, 15, 10, 4000, 8000, 12, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 271, 13, NULL, 100, 0, 20000, 7500, 'timestamp', NULL, 15, 10, 4000, 8000, 12, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 271, 14, NULL, 100, 0, 20000, 7500, 'timestamp', NULL, 15, 10, 4000, 8000, 12, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 261, 12, NULL, 100, 0, 20000, 7500, 'timestamp', NULL, 50, 10, 5000, 20000, 450, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 261, 13, NULL, 100, 0, 20000, 7500, 'timestamp', NULL, 50, 10, 5000, 20000, 450, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 261, 14, NULL, 100, 0, 20000, 7500, 'timestamp', NULL, 50, 10, 5000, 20000, 450, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 1490, 12, NULL, 100, 0, 20000, 100000, 'timestamp', NULL, 35, 10, 50000, 150000, 3000, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 1490, 13, NULL, 100, 0, 20000, 100000, 'timestamp', NULL, 35, 10, 50000, 150000, 3000, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 1490, 14, NULL, 100, 0, 20000, 100000, 'timestamp', NULL, 35, 10, 50000, 150000, 3000, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 403, 12, NULL, 100, 0, 20000, 6250, 'timestamp', NULL, 19, 10, 2500, 8000, 330, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 403, 13, NULL, 100, 0, 20000, 6250, 'timestamp', NULL, 19, 10, 2500, 8000, 330, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 403, 14, NULL, 100, 0, 20000, 6250, 'timestamp', NULL, 19, 10, 2500, 8000, 330, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 482, NULL, NULL, 60, 0, 20000, 5000, 'timestamp', NULL, 10, 10, 500, 10000, 190, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 483, NULL, NULL, 60, 0, 20000, 10000, 'timestamp', NULL, 19, 10, 1000, 20000, 760, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 484, NULL, NULL, 60, 0, 20000, 10000, 'timestamp', NULL, 19, 10, 1000, 20000, 760, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 485, NULL, NULL, 60, 0, 20000, 10000, 'timestamp', NULL, 19, 10, 1000, 20000, 760, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 481, NULL, NULL, 60, 0, 20000, 5000, 'timestamp', NULL, 10, 10, 500, 10000, 190, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 486, NULL, NULL, 60, 0, 20000, 25000, 'timestamp', NULL, 48, 10, 2500, 50000, 4750, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 482, NULL, NULL, 100, 0, 20000, 10000, 'timestamp', NULL, 18, 10, 7500, 25000, 350, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 483, NULL, NULL, 100, 0, 20000, 20000, 'timestamp', NULL, 35, 10, 15000, 50000, 1400, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 484, NULL, NULL, 100, 0, 20000, 20000, 'timestamp', NULL, 35, 10, 15000, 50000, 1400, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 485, NULL, NULL, 100, 0, 20000, 20000, 'timestamp', NULL, 35, 10, 15000, 50000, 1400, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 481, NULL, NULL, 100, 0, 20000, 10000, 'timestamp', NULL, 18, 10, 7500, 25000, 350, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 486, NULL, NULL, 100, 0, 20000, 50000, 'timestamp', NULL, 63, 10, 37500, 100000, 6250, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 362, NULL, NULL, 50, 0, 10000, 100, 'timestamp', NULL, 7, 10, 10, 500, 0.5, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'fixed', 42, NULL, NULL, 100, 0, 20000, 250000, 'timestamp', NULL, NULL, NULL, NULL, NULL, NULL, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'fixed', 51, NULL, NULL, 100, 0, 20000, 100000, 'timestamp', NULL, NULL, NULL, NULL, NULL, NULL, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'fixed', 44, NULL, NULL, 100, 0, 20000, 100000, 'timestamp', NULL, NULL, NULL, NULL, NULL, NULL, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'fixed', 464, NULL, NULL, 100, 0, 20000, 50000, 'timestamp', NULL, NULL, NULL, NULL, NULL, NULL, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'fixed', 527, NULL, NULL, 100, 0, 20000, 50000, 'timestamp', NULL, NULL, NULL, NULL, NULL, NULL, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'fixed', 293, NULL, NULL, 100, 0, 20000, 50000, 'timestamp', NULL, NULL, NULL, NULL, NULL, NULL, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'fixed', 294, NULL, NULL, 100, 0, 20000, 50000, 'timestamp', NULL, NULL, NULL, NULL, NULL, NULL, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'fixed', 46, NULL, NULL, 100, 0, 20000, 8000, 'timestamp', NULL, NULL, NULL, NULL, NULL, NULL, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'fixed', 40, NULL, NULL, 100, 0, 20000, 8000, 'timestamp', NULL, NULL, NULL, NULL, NULL, NULL, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'fixed', 48, NULL, NULL, 100, 0, 20000, 50000, 'timestamp', NULL, NULL, NULL, NULL, NULL, NULL, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'fixed', 295, NULL, NULL, 100, 0, 20000, 50000, 'timestamp', NULL, NULL, NULL, NULL, NULL, NULL, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'fixed', 1061, NULL, NULL, 100, 0, 20000, 10000, 'timestamp', NULL, NULL, NULL, NULL, NULL, NULL, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'fixed', 1060, NULL, NULL, 100, 0, 20000, 100, 'timestamp', NULL, NULL, NULL, NULL, NULL, NULL, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'fixed', 1029, NULL, NULL, 100, 0, 20000, 20000, 'timestamp', NULL, NULL, NULL, NULL, NULL, NULL, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'flex', 1032, NULL, NULL, 49, 0, 20000, 100, 'timestamp', NULL, 7, 10, 10, 500, 0.25, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'fixed', 1634, NULL, NULL, 100, 0, 20000, 10000, 'timestamp', NULL, NULL, NULL, NULL, NULL, NULL, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'fixed', 1635, NULL, NULL, 100, 0, 20000, 15000, 'timestamp', NULL, NULL, NULL, NULL, NULL, NULL, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'fixed', 1636, NULL, NULL, 100, 0, 20000, 20000, 'timestamp', NULL, NULL, NULL, NULL, NULL, NULL, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'fixed', 1685, NULL, NULL, 100, 0, 20000, 8000, 'timestamp', NULL, NULL, NULL, NULL, NULL, NULL, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'fixed', 1699, NULL, NULL, 100, 0, 20000, 100, 'timestamp', NULL, NULL, NULL, NULL, NULL, NULL, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 1700, NULL, NULL, 10, 0, 11000, 8000, 'timestamp', NULL, 9, 10, 1000, 9900, 500, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'fixed', 290, NULL, NULL, 100, 0, 20000, 30000, 'timestamp', NULL, NULL, NULL, NULL, NULL, NULL, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'fixed', 1376, NULL, NULL, 100, 0, 20000, 1, 'timestamp', NULL, NULL, NULL, NULL, NULL, NULL, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'sell',  'fixed', 31337, NULL, NULL, 0, 10, 0, 100, 'timestamp', NULL, NULL, NULL, NULL, NULL, NULL, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 342, NULL, NULL, 10, 0, 11000, 30, 'timestamp', NULL, 1, 10, 3, 30, 0.25, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 343, NULL, NULL, 10, 0, 11000, 200, 'timestamp', NULL, 5, 10, 20, 200, 1, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 344, NULL, NULL, 10, 0, 11000, 200, 'timestamp', NULL, 5, 10, 20, 200, 1, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 345, NULL, NULL, 10, 0, 11000, 200, 'timestamp', NULL, 5, 10, 20, 200, 1, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 349, NULL, NULL, 10, 0, 11000, 1000, 'timestamp', NULL, 7, 10, 100, 1000, 18, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 350, NULL, NULL, 10, 0, 11000, 1500, 'timestamp', NULL, 10, 10, 150, 1500, 68, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 351, NULL, NULL, 10, 0, 11000, 3000, 'timestamp', NULL, 19, 10, 300, 3000, 135, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 1402, NULL, NULL, 10, 0, 11000, 500, 'timestamp', NULL, 4, 10, 50, 500, 5, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 1403, NULL, NULL, 10, 0, 11000, 1500, 'timestamp', NULL, 10, 10, 150, 1500, 27, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 1404, NULL, NULL, 10, 0, 11000, 1000, 'timestamp', NULL, 7, 10, 100, 1000, 9, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 383, NULL, NULL, 10, 0, 11000, 20, 'timestamp', NULL, 1, 10, 2, 20, 0.5, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 384, NULL, NULL, 10, 0, 11000, 20, 'timestamp', NULL, 1, 10, 2, 20, 0.5, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 385, NULL, NULL, 10, 0, 11000, 20, 'timestamp', NULL, 1, 10, 2, 20, 0.5, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 386, NULL, NULL, 10, 0, 11000, 10, 'timestamp', NULL, 1, 10, 1, 10, 0.5, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 390, NULL, NULL, 10, 0, 11000, 10, 'timestamp', NULL, 1, 10, 1, 10, 0.5, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 1063, NULL, NULL, 10, 0, 11000, 50, 'timestamp', NULL, 2, 10, 5, 50, 0.25, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 1064, NULL, NULL, 10, 0, 11000, 50, 'timestamp', NULL, 2, 10, 5, 50, 0.25, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 953, NULL, NULL, 10, 0, 11000, 50, 'timestamp', NULL, 2, 10, 5, 50, 0.25, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 952, NULL, NULL, 10, 0, 11000, 50, 'timestamp', NULL, 2, 10, 5, 50, 0.25, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 1117, NULL, NULL, 10, 0, 11000, 500, 'timestamp', NULL, 13, 10, 50, 500, 0.5, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 1032, NULL, NULL, 75, 0, 11000, 20, 'timestamp', NULL, 1, 10, 2, 20, 0.25, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 1012, NULL, NULL, 10, 0, 11000, 100, 'timestamp', NULL, 3, 10, 10, 100, 0.25, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 1009, NULL, NULL, 10, 0, 11000, 100, 'timestamp', NULL, 3, 10, 10, 100, 0.25, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 346, NULL, NULL, 10, 0, 11000, 10, 'timestamp', NULL, 1, 10, 1, 10, 0.25, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 233, NULL, NULL, 10, 0, 11000, 100, 'timestamp', NULL, 3, 10, 10, 100, 0.25, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 1101, NULL, NULL, 10, 0, 11000, 100, 'timestamp', NULL, 14, 10, 10, 500, 5, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 1102, NULL, NULL, 10, 0, 11000, 500, 'timestamp', NULL, 27, 10, 50, 1000, 10, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 1103, NULL, NULL, 10, 0, 11000, 1000, 'timestamp', NULL, 137, 10, 100, 5000, 50, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 479, NULL, NULL, 10, 0, 11000, 200, 'timestamp', NULL, 14, 10, 20, 1000, 10, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 487, NULL, NULL, 10, 0, 11000, 500, 'timestamp', NULL, 28, 10, 50, 2000, 20, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 790, NULL, NULL, 10, 0, 11000, 50, 'timestamp', NULL, 2, 10, 5, 50, 0.25, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 477, NULL, NULL, 10, 0, 11000, 100, 'timestamp', NULL, 3, 10, 10, 100, 0.25, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 1124, NULL, NULL, 10, 0, 11000, 50, 'timestamp', NULL, 2, 10, 5, 50, 0.25, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 1118, NULL, NULL, 10, 0, 11000, 300, 'timestamp', NULL, 8, 10, 30, 300, 0.5, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 962, NULL, NULL, 10, 0, 11000, 300, 'timestamp', NULL, 8, 10, 30, 300, 0.5, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 1119, NULL, NULL, 10, 0, 11000, 300, 'timestamp', NULL, 8, 10, 30, 300, 0.5, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 222, NULL, NULL, 10, 0, 11000, 200, 'timestamp', NULL, 5, 10, 20, 200, 7, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 270, NULL, NULL, 10, 0, 11000, 50, 'timestamp', NULL, 3, 10, 5, 100, 0.25, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 299, NULL, NULL, 10, 0, 11000, 100, 'timestamp', NULL, 3, 10, 10, 100, 0.25, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 336, NULL, NULL, 10, 0, 11000, 30, 'timestamp', NULL, 1, 10, 3, 30, 0.25, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 1700, NULL, NULL, 10, 0, 11000, 8000, 'timestamp', NULL, 21, 10, 1000, 9900, 1000, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 644, NULL, NULL, 70, 0, 11000, 100, 'timestamp', NULL, 3, 10, 10, 100, 0.25, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 650, NULL, NULL, 70, 0, 11000, 100, 'timestamp', NULL, 3, 10, 10, 100, 0.25, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 286, NULL, NULL, 75, 0, 11000, 5000, 'timestamp', NULL, 32, 10, 500, 5000, 25, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 288, NULL, NULL, 75, 0, 11000, 2000, 'timestamp', NULL, 13, 10, 200, 2000, 8, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 1081, NULL, NULL, 75, 0, 11000, 500, 'timestamp', NULL, 13, 10, 50, 500, 2.5, 'timestamp')");
dbi.Update("INSERT IGNORE nyu_tradepost_market VALUES (NULL, 'buy',  'flex', 223, NULL, NULL, 75, 0, 11000, 1500, 'timestamp', NULL, 10, 10, 150, 1500, 5, 'timestamp')");
  }

  function lifx_TradepostAutoMaintain::version() {
    return "0.0.1";
  }
};
activatePackage(lifx_TradepostAutoMaintain);
LiFx::registerCallback($LiFx::hooks::mods, setup, lifx_TradepostAutoMaintain);