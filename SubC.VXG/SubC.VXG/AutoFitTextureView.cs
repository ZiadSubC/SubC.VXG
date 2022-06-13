// <copyright file="AutoFitTextureView.cs" company="SubC Imaging">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SubC.VXG
{
    using Android.Content;
    using Android.Util;
    using Android.Views;
    using System;

    /// <summary>
    /// Texture view for preview.
    /// </summary>
    public class AutoFitTextureView : TextureView
    {
        private int mRatioHeight = 0;
        private int mRatioWidth = 0;

        /// <param name="context"> Initializing context.</param>
        public AutoFitTextureView(Context context)
            : this(context, null)
        {
        }

        /// <param name="context"> context. </param>
        /// <param name="attrs">Initializing attributes.</param>
        public AutoFitTextureView(Context context, IAttributeSet attrs)
            : this(context, attrs, 0)
        {
        }

        /// <param name="context">Context.</param>
        /// <param name="attrs">Attributes.</param>
        /// <param name="defStyle">Style.</param>
        public AutoFitTextureView(Context context, IAttributeSet attrs, int defStyle)
            : base(context, attrs, defStyle)
        {
        }

        /// <param name="width">Setting width.</param>
        /// <param name="height">Setting height.</param>
        /// <exception cref="ArgumentException"></exception>
        public void SetAspectRatio(int width, int height)
        {
            if (width == 0 || height == 0)
                throw new ArgumentException("Size cannot be negative.");
            mRatioWidth = width;
            mRatioHeight = height;
            RequestLayout();
        }

        /// <param name="widthMeasureSpec">Get width size.</param>
        /// <param name="heightMeasureSpec">Get height size.</param>
        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
            int width = MeasureSpec.GetSize(widthMeasureSpec);
            int height = MeasureSpec.GetSize(heightMeasureSpec);
            if (0 == mRatioWidth || 0 == mRatioHeight)
            {
                SetMeasuredDimension(width, height);
            }
            else
            {
                if (width < (float)height * mRatioWidth / (float)mRatioHeight)
                {
                    SetMeasuredDimension(width, width * mRatioHeight / mRatioWidth);
                }
                else
                {
                    SetMeasuredDimension(height * mRatioWidth / mRatioHeight, height);
                }
            }
        }
    }
}