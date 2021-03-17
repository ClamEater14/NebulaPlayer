﻿/*
 * Joycelyn Wong
 * December 22, 2019
 * This project is to create a kpopdatabase for user to store album's information
 * This class is to create a studio album
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KpopAlbumDatabase
{
    class StudioAlbum : Album
    {
        public StudioAlbum(string title, string artist, int year, string category, string description, Image albumImage, string albumType)
        {
            // create a single
            this.title = title;
            this.artist = artist;
            this.year = year;
            this.category = category;
            this.description = description;
            this.albumImage = albumImage;
            this.albumType = albumType;
        }

        /// <summary>
        ///  Adds song to this particular album that they are not already existed
        /// </summary>
        /// <param name="song"></param>
        /// <returns>>true if song was uniqe, false if already existed</returns>
        public override bool AddSongs(Songs song)
        {
            // if song is already existed, dont add
            if (songs.Contains(song))
            {
                return false;
            }
            // if song is new, add to this album
            else
            {
                songs.Add(song);
                return true;
            }
        }

        public override bool AddSongs(string songName)
        {
            Songs song = new Songs(songName);
            return AddSongs(song);
        }

        /// <summary>
        /// Removes unwanted song from this album
        /// </summary>
        /// <param name="song"></param>
        /// <returns>true if song was existed, false if not existed</returns>
        public override bool RemoveSongs(Songs song)
        {
            // song is in the album, remove them
            if (songs.Contains(song) && songs.Count > 10)
            {
                songs.Remove(song);
                return true;
            }
            // song is not in the album
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Get the song
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public override Songs GetSong(int index)
        {
            // if the index is valid, return the student at index
            if (index >= 0 && index < songs.Count)
            {
                return songs[index];
            }

            // invalid index causes null return
            return null;
        }
    }
}
